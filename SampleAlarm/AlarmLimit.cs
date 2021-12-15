using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;
using Utils;
using Models;
using BLL;

namespace SampleAlarm
{
    public partial class AlarmLimit : Form
    {
        public AlarmLimit()
        {
            InitializeComponent();
        }

        private void AlarmLimit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AlarmViewModels.AlarmList;
            myDataGrid.AdaptiveWidth(dataGridView1);
        }

        private void tsmi_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("选择要修改的数据信息");
                return;
            }
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            AlarmListModel model = AlarmListBLL.GetModelByID(ID);
            ModifyAlarmLimit _modifyAlarmLimit = new ModifyAlarmLimit(model);
            _modifyAlarmLimit.ShowDialog();
        }

        private void tsmi_Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AlarmViewModels.AlarmList;
        }
    }
}
