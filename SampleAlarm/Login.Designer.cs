namespace SampleAlarm
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.txt_UID = new System.Windows.Forms.TextBox();
            this.lab_Code = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lab_Pwd = new System.Windows.Forms.Label();
            this.lab_Title = new System.Windows.Forms.Label();
            this.lab_UID = new System.Windows.Forms.Label();
            this.verificationCode1 = new myControls.VerificationCode(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationCode1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.BackgroundImage = global::SampleAlarm.Properties.Resources.Minimize;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minimize.Location = new System.Drawing.Point(421, 3);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(23, 23);
            this.btn_Minimize.TabIndex = 9;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            this.btn_Minimize.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Minimize.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = global::SampleAlarm.Properties.Resources.Close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(455, 3);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(23, 23);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Close.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // txt_Code
            // 
            this.txt_Code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Code.Location = new System.Drawing.Point(175, 183);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(105, 29);
            this.txt_Code.TabIndex = 2;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Pwd.Location = new System.Drawing.Point(175, 140);
            this.txt_Pwd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(217, 29);
            this.txt_Pwd.TabIndex = 1;
            // 
            // txt_UID
            // 
            this.txt_UID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_UID.Location = new System.Drawing.Point(175, 97);
            this.txt_UID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UID.Name = "txt_UID";
            this.txt_UID.Size = new System.Drawing.Size(217, 29);
            this.txt_UID.TabIndex = 0;
            // 
            // lab_Code
            // 
            this.lab_Code.AutoSize = true;
            this.lab_Code.BackColor = System.Drawing.Color.Transparent;
            this.lab_Code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Code.ForeColor = System.Drawing.Color.White;
            this.lab_Code.Location = new System.Drawing.Point(76, 186);
            this.lab_Code.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Code.Name = "lab_Code";
            this.lab_Code.Size = new System.Drawing.Size(58, 21);
            this.lab_Code.TabIndex = 11;
            this.lab_Code.Text = "验证码";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Orange;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(80, 233);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(311, 37);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "登    陆";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lab_Pwd
            // 
            this.lab_Pwd.AutoSize = true;
            this.lab_Pwd.BackColor = System.Drawing.Color.Transparent;
            this.lab_Pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Pwd.ForeColor = System.Drawing.Color.White;
            this.lab_Pwd.Location = new System.Drawing.Point(76, 143);
            this.lab_Pwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Pwd.Name = "lab_Pwd";
            this.lab_Pwd.Size = new System.Drawing.Size(74, 21);
            this.lab_Pwd.TabIndex = 12;
            this.lab_Pwd.Text = "登陆密码";
            // 
            // lab_Title
            // 
            this.lab_Title.BackColor = System.Drawing.Color.Transparent;
            this.lab_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_Title.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Title.ForeColor = System.Drawing.Color.White;
            this.lab_Title.Location = new System.Drawing.Point(0, 0);
            this.lab_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(480, 96);
            this.lab_Title.TabIndex = 13;
            this.lab_Title.Text = "欢迎使用船舶机舱监测监控系统";
            this.lab_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lab_Title_MouseDown);
            this.lab_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lab_Title_MouseMove);
            // 
            // lab_UID
            // 
            this.lab_UID.AutoSize = true;
            this.lab_UID.BackColor = System.Drawing.Color.Transparent;
            this.lab_UID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_UID.ForeColor = System.Drawing.Color.White;
            this.lab_UID.Location = new System.Drawing.Point(76, 99);
            this.lab_UID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_UID.Name = "lab_UID";
            this.lab_UID.Size = new System.Drawing.Size(74, 21);
            this.lab_UID.TabIndex = 5;
            this.lab_UID.Text = "登录用户";
            // 
            // verificationCode1
            // 
            this.verificationCode1.CodeValue = null;
            this.verificationCode1.LineCount = 50;
            this.verificationCode1.Location = new System.Drawing.Point(284, 181);
            this.verificationCode1.Name = "verificationCode1";
            this.verificationCode1.NumberCount = 5;
            this.verificationCode1.PixelCount = 250;
            this.verificationCode1.Size = new System.Drawing.Size(108, 33);
            this.verificationCode1.TabIndex = 15;
            this.verificationCode1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(480, 293);
            this.Controls.Add(this.verificationCode1);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.txt_UID);
            this.Controls.Add(this.lab_Code);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lab_Pwd);
            this.Controls.Add(this.lab_Title);
            this.Controls.Add(this.lab_UID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(480, 293);
            this.MinimumSize = new System.Drawing.Size(480, 293);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationCode1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Minimize;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.TextBox txt_UID;
        private System.Windows.Forms.Label lab_Code;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lab_Pwd;
        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.Label lab_UID;
        private myControls.VerificationCode verificationCode1;
    }
}