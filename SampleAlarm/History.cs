using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;
using Utils;

namespace SampleAlarm
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AlarmHistoryBLL.GetHistoryViewModel();
            myDataGrid.AdaptiveWidth_History(dataGridView1);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("将清空所有报警记录，确定？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int count = AlarmHistoryBLL.DeleteAllHistory();
                MessageBox.Show("已删除" + count.ToString() + "行报警记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
