using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//引用额外的命名空间
using System.Data.SqlClient;
using FR102DLL;
using System.IO.Ports; 

namespace RFIDDemo
{
    public partial class Form1 : Form
    {
        //数据库地址
        //private static string serverIP = "localhost\\sqlexpress";

        //连接本地数据库的字符串
        private static string connString = Properties.Settings.Default.ConnString;
        
        FR102Reader Reader = new FR102Reader();

        public Form1()
        {
            InitializeComponent();

            //程序初始化时从数据库中读取已经注册的用户信息
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = connString;

                string sqlScript = "select * from UserInfo";

                DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, sqlScript);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //有用户存在
                    //创建一个临时存储用户信息的列表变量
                    List<string> userItems = new List<string>();

                    //循环数据库中每一个用户信息，将每个姓名和班级当作一行存到列表变量中
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string Name = ds.Tables[0].Rows[i]["Name"].ToString();

                        string Class = ds.Tables[0].Rows[i]["Class"].ToString();

                        string info = String.Format("{0}： {1}       班级：{2}", i + 1, Name, Class);

                        userItems.Add(info);
                    }

                    //每次先将窗体上的列表控件清空
                    //然后将其数据源设置为列表变量
                    lBUserInfo.DataSource = null;
                    lBUserInfo.DataSource = userItems;
                }
                else
                {
                    //没有数据，将现有数据清空
                    lBUserInfo.Items.Clear();
                }

                //操作结束后关闭连接
                conn.Close();
            }
            catch
            {
                //操作结束后关闭连接
                conn.Close();

                MessageBox.Show("连接数据库失败.");
            }
        }

        private void btnRegUser_Click(object sender, EventArgs e)
        {
            //先判断是否有字段为空
            if (tBUserName.Text == "" || tBPassword.Text == "" || tBName.Text == "" || tBClass.Text == "" || tBCardID.Text == "")
            {
                MessageBox.Show("请确认所有字段不为空！");
            }
            else
            {
                //先尝试连接硬件设备并读卡
                string temp = readCardID();

                if (temp != "正确")
                {
                    MessageBox.Show(temp);
                }
                else
                {
                    //尝试注册用户
                    SqlConnection conn = new SqlConnection();

                    try
                    {
                        conn.ConnectionString = connString;
                        conn.Open();

                        //查看新用户名是否已被注册
                        string sqlScript = "select * from UserInfo where UserName = N'" + tBUserName.Text + "'";

                        DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, sqlScript);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            //该用户名已存在
                            conn.Close();

                            MessageBox.Show("该用户名已存在！");
                        }
                        else
                        {
                            //查看该卡号是否已被注册
                            sqlScript = "select * from UserInfo where CardID = '" + tBCardID.Text + "'";

                            ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, sqlScript);

                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                //该卡号已存在，无法注册。关闭连接
                                conn.Close();

                                MessageBox.Show("该卡号已存在！");
                            }
                            else
                            {
                                //新用户可以注册，调用插入语句注册新用户
                                sqlScript = "insert into UserInfo values(N'" + tBUserName.Text + "','" + tBPassword.Text + "',N'" + tBName.Text + "','" + tBClass.Text + "','" + tBCardID.Text + "')";

                                int result = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, sqlScript);

                                if (result > 0)
                                {
                                    MessageBox.Show("注册成功！");
                                }
                                else
                                {
                                    MessageBox.Show("注册失败！");
                                }

                                //获取最新的用户列表并显示到列表控件中
                                sqlScript = "select * from UserInfo";

                                ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, sqlScript);

                                if (ds.Tables[0].Rows.Count > 0)
                                {
                                    //创建一个临时存储用户信息的列表变量
                                    List<string> userItems = new List<string>();

                                    //循环数据库中每一个用户信息，将每个姓名和班级当作一行存到列表变量中
                                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                    {
                                        string Name = ds.Tables[0].Rows[i]["Name"].ToString();

                                        string Class = ds.Tables[0].Rows[i]["Class"].ToString();

                                        string info = String.Format("{0}： {1}       班级：{2}", i + 1, Name, Class);

                                        userItems.Add(info);
                                    }

                                    //每次先将窗体上的列表控件清空
                                    //然后将其数据源设置为列表变量
                                    lBUserInfo.DataSource = null;
                                    lBUserInfo.DataSource = userItems;
                                }
                                else
                                {
                                    //没有数据，将现有数据清空
                                    lBUserInfo.Items.Clear();
                                }

                                //操作完毕，关闭连接
                                conn.Close();
                            }
                        }
                    }
                    catch
                    {
                        //无法连接数据库，关闭连接
                        conn.Close();

                        MessageBox.Show("连接数据库失败.");
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            //用户可以用账户信息和学生卡两种方式登录
            if (tBLoginUserName.Text == "" && tBLoginPassword.Text == "")
            {
                //用户名或密码为空，尝试使用读取卡号登录
                try
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    //先获取卡号
                    string temp = readCardID();

                    if (temp != "正确")
                    {
                        MessageBox.Show(temp);
                    }

                    string CardID = tBCardID.Text;

                    //根据卡号获取用户所有信息
                    string sqlScript = "select * from UserInfo where CardID = '" + CardID + "'";

                    DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, sqlScript);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //登录成功，提取姓名和班级信息
                        string Name = ds.Tables[0].Rows[0]["Name"].ToString();

                        string Class = ds.Tables[0].Rows[0]["Class"].ToString();

                        conn.Close();

                        MessageBox.Show(string.Format("欢迎{0}班的{1}同学。", Class, Name));
                    }
                    else
                    {
                        //登录失败，关闭连接
                        conn.Close();

                        MessageBox.Show("登录失败！");
                    }
                }
                catch
                {
                    conn.Close();

                    MessageBox.Show("连接数据库失败.");
                }
            }
            else
            {
                try
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    //先判断用户名和密码是否匹配
                    string sqlScript = "select * from UserInfo where UserName = N'" + tBLoginUserName.Text + "' and Password='" + tBLoginPassword.Text + "'";

                    DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, sqlScript);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //登录成功，提取姓名和班级信息
                        string Name = ds.Tables[0].Rows[0]["Name"].ToString();

                        string Class = ds.Tables[0].Rows[0]["Class"].ToString();

                        conn.Close();

                        MessageBox.Show(string.Format("欢迎{0}班的{1}同学。", Class, Name));
                    }
                    else
                    {
                        //登录失败，关闭连接
                        conn.Close();

                        MessageBox.Show("用户名或密码错误！");
                    }
                }
                catch
                {
                    //连接数据库失败，关闭连接
                    conn.Close();

                    MessageBox.Show("连接数据库失败.");
                }
            }
        }

        private string readCardID()
        {
            string[] ArryPort = SerialPort.GetPortNames();

            bool deviceFlag = false;

            foreach (var t in ArryPort)
            {
                var value = Reader.OpenSerialPort(t);

                value = Reader.TestReader();

                if (value != 0x00) continue;
                value = Reader.RestartReader();

                if (value == 0x00)
                {
                    deviceFlag = true;

                    break;
                }
            }

            if (deviceFlag)
            {
                var data = new byte[2];
                var value = Reader.PcdRequest(0x52, ref data);

                if (value == 0x03)
                {
                    return "请求失败";
                }

                if (value == 0x02)
                {
                    return "读卡区无卡";
                }

                data = new byte[5];

                value = Reader.PcdAnticoll(ref data);

                if (value != 0x00)
                {
                    return "未知错误";
                }

                var strSnr = "";

                var bArraySnr = new byte[data.Length];

                for (var i = 0; i < data.Length; i++)
                {
                    strSnr = strSnr + String.Format("{0:X2} ", data[i]);
                    bArraySnr[i] = data[i];
                }

                tBCardID.Text = strSnr;

                return "正确";
            }

            return "无法读取卡号，请检查设备连接是否正确！";
        }
    }
}
