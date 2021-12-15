using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace SampleAlarm
{
    enum Log
    {
        登陆成功,
        用户名错误,
        密码错误,
        验证码错误,
        未知信息
    }

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region 渐变背景
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //获取画布
            Graphics g = e.Graphics;

            //Rectangle rec = new Rectangle(new Point(0,0),new Size(this.Width,this.Height));
            Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);

            LinearGradientBrush brush = new LinearGradientBrush(rec, Color.FromArgb(225, 101, 127), Color.FromArgb(93, 127, 124), LinearGradientMode.BackwardDiagonal);

            g.FillRectangle(brush, rec);
        }
        #endregion

        #region 无边框拖动

        private Point mPoint;
        private void lab_Title_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = e.Location;
        }

        private void lab_Title_MouseMove(object sender, MouseEventArgs e)
        {
            //只有左键才能拖动
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        #region 按钮
        private void btn_Close_Click(object sender, EventArgs e)=> this.Close();
        private void btn_Minimize_Click(object sender, EventArgs e)=> this.WindowState = FormWindowState.Minimized;

        private int btnBigSize = 45;
        private int btnSmallSize = 35;
        private int Diff = 5;
        private void btn_MouseHover(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Size = new Size(btnBigSize, btnBigSize);
            //这句代码有时候不稳定，容易出现bug
            //pb.Location = new Point(pb.Location.X - Diff, pb.Location.Y - Diff);
            if (pb == btn_Close)
            {
                pb.Location = new Point(683 - Diff, 5 - Diff);
            }
            if (pb == btn_Minimize)
            {
                pb.Location = new Point(632 - Diff, 5 - Diff);
            }
        }
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Size = new Size(btnSmallSize, btnSmallSize);
            //这句代码有时候不稳定，容易出现bug
            //pb.Location = new Point(pb.Location.X + Diff, pb.Location.Y + Diff);
            if (pb == btn_Close)
            {
                pb.Location = new Point(683, 5);
            }
            if (pb == btn_Minimize)
            {
                pb.Location = new Point(632, 5);
            }
        }

        #endregion

        #region 登陆
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = txt_UID.Text.Trim();
            string pwd = txt_Pwd.Text.Trim();
            string code = txt_Code.Text.Trim();
            string msg;
            if (LoginForm(user, pwd, code, out msg))
            {
                this.Hide();
                Main mainFrm = new Main();
                mainFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show($"登陆信息：{msg}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private bool LoginForm(string user, string pwd, string Code, out string msg)
        {
            if (AdminService.Login(user, pwd) == 2 && Code == verificationCode1.CodeValue)
            {
                msg = Log.登陆成功.ToString();
                return true;
            }
            else if (AdminService.Login(user, pwd) == 1 && Code == verificationCode1.CodeValue)
            {
                msg = Log.密码错误.ToString();
                return false;
            }
            else if (AdminService.Login(user, pwd) == 0 && Code == verificationCode1.CodeValue)
            {
                msg = Log.用户名错误.ToString();
                return false;
            }
            else if (AdminService.Login(user, pwd) == 2)
            {
                msg = Log.验证码错误.ToString();
                return false;
            }
            else
            {
                msg = Log.未知信息.ToString();
                return false;
            }
            #endregion
        }
    }
}
