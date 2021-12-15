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
using ViewModels;

namespace SampleAlarm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            _alarmListBLL = new AlarmListBLL("127.0.0.1",502);
            instrumentList = new List<myControls.MyInstrument>()
            {
                myInstrument1,myInstrument2,myInstrument3,myInstrument4,myInstrument5,
                myInstrument6,myInstrument7,myInstrument8,myInstrument9,myInstrument10
            };
            ledList = new List<myControls.MyLED>()
            {
                myLED1,myLED2,myLED3,myLED4,myLED5,
                myLED6,myLED7,myLED8,myLED9,myLED10
            };
        }

        private AlarmListBLL _alarmListBLL;

        private List<myControls.MyInstrument> instrumentList;
        private List<myControls.MyLED> ledList;

        private void Main_Load(object sender, EventArgs e)
        {
            _alarmListBLL.GetAlarmListModel();
            dataGridView1.DataSource = AlarmViewModels.AlarmList;
            myDataGrid.AdaptiveWidth(dataGridView1);
            timer1.Start();

            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(100);
                    await _alarmListBLL.Refresh();
                }
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.Refresh();

            for (int i = 0; i < AlarmViewModels.AlarmList.Count; i++)
            {
                AlarmViewModels.AlarmList[i].UTC = DateTime.Now;

                instrumentList[i].Value = AlarmViewModels.AlarmList[i].Value;

                if (AlarmViewModels.AlarmList[i].State == StateType.Alarming.ToString() || AlarmViewModels.AlarmList[i].State == StateType.Responsed.ToString())
                {
                    ledList[i].Value = false;
                }
                else if (AlarmViewModels.AlarmList[i].State == StateType.Nomal.ToString())
                {
                    ledList[i].Value = true;
                }


                if (AlarmViewModels.AlarmList[i].State == StateType.Alarming.ToString())
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if(AlarmViewModels.AlarmList[i].State == StateType.Responsed.ToString())
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
            manager.Text = MainViewModel.managerName;
            managerDate.Text = MainViewModel.UserDate;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Management_Click(object sender, EventArgs e)
        {
            Management m = new Management();
            m.ShowDialog();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btn_History_Click(object sender, EventArgs e)
        {
            History _history = new History();
            _history.ShowDialog();
        }

        private void btn_AlarmLimit_Click(object sender, EventArgs e)
        {
            AlarmLimit _alarmLimit = new AlarmLimit();
            _alarmLimit.ShowDialog();
        }

        private void btn_RealtimeCurve_Click(object sender, EventArgs e)
        {
            RealtimeCurve _realtimeCurve = new RealtimeCurve();
            _realtimeCurve.ShowDialog();
        }

        private void btn_Responsed_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AlarmViewModels.AlarmList.Count; i++)
            {
                if(AlarmViewModels.AlarmList[i].State == StateType.Alarming.ToString())
                {
                    AlarmViewModels.AlarmList[i].State = StateType.Responsed.ToString();
                }
            }
        }
    }
}
