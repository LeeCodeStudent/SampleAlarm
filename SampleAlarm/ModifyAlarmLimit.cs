using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;
using Utils;

namespace SampleAlarm
{
    public partial class ModifyAlarmLimit : Form
    {
        private AlarmListModel model;
        public ModifyAlarmLimit(AlarmListModel model)
        {
            InitializeComponent();

            this.model = model;
        }

        private void ModifyAlarmLimit_Load(object sender, EventArgs e)
        {
            txt_ID.Text = this.model.ID.ToString();
            txt_LoLoAlarm.Text = this.model.LoLoAlarm.ToString();
            txt_LowAlarm.Text = this.model.LowAlarm.ToString();
            txt_HighAlarm.Text = this.model.HighAlarm.ToString();
            txt_HiHiAlarm.Text = this.model.HiHiAlarm.ToString();

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(item.Text.Trim()))
                    {
                        MessageBox.Show("请填写完整信息");
                        item.Focus();
                        return;
                    }
                }
            }

            //主键ID不动
            model.ID = Converter.ToInt32(txt_ID.Text);
            model.LoLoAlarm = Converter.ToInt32(txt_LoLoAlarm.Text);
            model.LowAlarm = Converter.ToInt32(txt_LowAlarm.Text);
            model.HighAlarm = Converter.ToInt32(txt_HighAlarm.Text);
            model.HiHiAlarm = Converter.ToInt32(txt_HiHiAlarm.Text);

            if (AlarmListBLL.UpdataLimit(model))
            {
                MessageBox.Show("修改成功，请务必重启软件以完成配置");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }

        }
    }
}
