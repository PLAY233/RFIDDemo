namespace RFIDDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBUserName = new System.Windows.Forms.TextBox();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBClass = new System.Windows.Forms.TextBox();
            this.tBCardID = new System.Windows.Forms.TextBox();
            this.btnRegUser = new System.Windows.Forms.Button();
            this.lBUserInfo = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBLoginPassword = new System.Windows.Forms.TextBox();
            this.tBLoginUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lBUserInfo);
            this.groupBox1.Controls.Add(this.btnRegUser);
            this.groupBox1.Controls.Add(this.tBCardID);
            this.groupBox1.Controls.Add(this.tBClass);
            this.groupBox1.Controls.Add(this.tBName);
            this.groupBox1.Controls.Add(this.tBPassword);
            this.groupBox1.Controls.Add(this.tBUserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "注册";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "班级：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "卡号：";
            // 
            // tBUserName
            // 
            this.tBUserName.Location = new System.Drawing.Point(88, 47);
            this.tBUserName.Name = "tBUserName";
            this.tBUserName.Size = new System.Drawing.Size(100, 21);
            this.tBUserName.TabIndex = 5;
            // 
            // tBPassword
            // 
            this.tBPassword.Location = new System.Drawing.Point(88, 80);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(100, 21);
            this.tBPassword.TabIndex = 6;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(88, 113);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(100, 21);
            this.tBName.TabIndex = 7;
            // 
            // tBClass
            // 
            this.tBClass.Location = new System.Drawing.Point(88, 146);
            this.tBClass.Name = "tBClass";
            this.tBClass.Size = new System.Drawing.Size(100, 21);
            this.tBClass.TabIndex = 8;
            // 
            // tBCardID
            // 
            this.tBCardID.Location = new System.Drawing.Point(88, 179);
            this.tBCardID.Name = "tBCardID";
            this.tBCardID.Size = new System.Drawing.Size(100, 21);
            this.tBCardID.TabIndex = 9;
            this.tBCardID.Text = "等待读取卡号";
            // 
            // btnRegUser
            // 
            this.btnRegUser.Location = new System.Drawing.Point(88, 230);
            this.btnRegUser.Name = "btnRegUser";
            this.btnRegUser.Size = new System.Drawing.Size(75, 23);
            this.btnRegUser.TabIndex = 10;
            this.btnRegUser.Text = "注册";
            this.btnRegUser.UseVisualStyleBackColor = true;
            this.btnRegUser.Click += new System.EventHandler(this.btnRegUser_Click);
            // 
            // lBUserInfo
            // 
            this.lBUserInfo.FormattingEnabled = true;
            this.lBUserInfo.ItemHeight = 12;
            this.lBUserInfo.Location = new System.Drawing.Point(219, 50);
            this.lBUserInfo.Name = "lBUserInfo";
            this.lBUserInfo.Size = new System.Drawing.Size(152, 196);
            this.lBUserInfo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "已注册学生列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tBLoginPassword);
            this.groupBox2.Controls.Add(this.tBLoginUserName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(425, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "登录";
            // 
            // tBLoginPassword
            // 
            this.tBLoginPassword.Location = new System.Drawing.Point(91, 83);
            this.tBLoginPassword.Name = "tBLoginPassword";
            this.tBLoginPassword.Size = new System.Drawing.Size(100, 21);
            this.tBLoginPassword.TabIndex = 10;
            // 
            // tBLoginUserName
            // 
            this.tBLoginUserName.Location = new System.Drawing.Point(91, 50);
            this.tBLoginUserName.Name = "tBLoginUserName";
            this.tBLoginUserName.Size = new System.Drawing.Size(100, 21);
            this.tBLoginUserName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "密码：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "用户名：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "您可以使用账户或学生卡登录";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(91, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 295);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID实验终极挑战";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBCardID;
        private System.Windows.Forms.TextBox tBClass;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lBUserInfo;
        private System.Windows.Forms.Button btnRegUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBLoginPassword;
        private System.Windows.Forms.TextBox tBLoginUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

