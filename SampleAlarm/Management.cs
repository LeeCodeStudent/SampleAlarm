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
using ViewModels;

namespace SampleAlarm
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private static List<ManagementModel> list;

        //重写ProcessCmdKey方法，表示键盘按下的事件
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int wm_keydown = 256;
            int wm_sysketdown = 260;
            if (msg.Msg == wm_keydown || msg.Msg == wm_sysketdown)
            {
                if (keyData == Keys.Escape)
                {
                    this.Close();
                }
            }
            return false;
        }


        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != String.Empty)
            {
                string DutyName = textBox1.Text.Trim();
                DateTime DutyTime = DateTime.Now;

                ManagementModel model = new ManagementModel()
                {
                    DutyName = DutyName,
                    DutyTime = DutyTime
                };

                //执行并返回值
                if (ManagementService.CreateManagement(model))
                {
                    MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainViewModel.managerName = DutyName;
                    MainViewModel.UserDate = DutyTime.ToString();
                }
                else
                {
                    MessageBox.Show("添加失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("值班人员不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bt_Qurey_Click(object sender, EventArgs e)
        {
            LoadManagements();
        }

        private void LoadManagements()
        {
            list = ManagementService.GetManagementModel();
            dataGridView1.DataSource = list;
            dataGridView1.ClearSelection();
            myDataGrid.AdaptiveWidth_Management(dataGridView1);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("将清空所有值班记录，确定？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int count = ManagementService.RemoveAllManagementHistory();
                MessageBox.Show("已删除" + count.ToString() + "行值班记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }      
        }
    }

}
