using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;   //与chart相关的引用
using System.Threading;
using ViewModels;
using Models;

namespace SampleAlarm
{
    public partial class RealtimeCurve : Form
    {
        private DateTime minValue, maxValue;    //横坐标最小和最大值

        private Series newSeries;

        private int currentCurve = 0;
        public RealtimeCurve()
        {
            InitializeComponent();
        }

        private void RealtimeCurve_Load(object sender, EventArgs e)
        {
            minValue = DateTime.Now;            //x轴最小刻度 
            maxValue = minValue.AddSeconds(1);  //X轴最大刻度,比最小刻度大1秒
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";          //毫秒格式： hh:mm:ss.fff ，后面几个f则保留几位毫秒小数，此时要注意轴的最大值和最小值不要差太大
            chart1.ChartAreas[0].AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Milliseconds;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 100;                   //坐标值间隔200 ms
            chart1.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false;        //防止X轴坐标跳跃
            chart1.ChartAreas[0].AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Milliseconds;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 100;

            chart1.ChartAreas[0].AxisX.Minimum = minValue.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = maxValue.ToOADate();

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash; //设置网格类型为虚线
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;//网格Y轴线类型

            chart1.Series.Clear();

            newSeries = new Series("Series1");
            newSeries.ChartType = SeriesChartType.Line;
            newSeries.BorderWidth = 4;
            newSeries.Color = Color.FromArgb(0, 0, 255);
            newSeries.XValueType = ChartValueType.DateTime;
            chart1.Series.Add(newSeries);

            timer1.Start();

        }

        public void AddNewPoint(DateTime timeStamp, System.Windows.Forms.DataVisualization.Charting.Series ptSeries)
        {
            // Add new data point to its series.
            ptSeries.Points.AddXY(timeStamp.ToOADate(), AlarmViewModels.AlarmList[currentCurve].Value);
            // remove all points from the source series older than 1 seconds.
            double removeBefore = timeStamp.AddSeconds((double)(1) * (-1)).ToOADate();

            //remove oldest values to maintain a constant number of data points
            while (ptSeries.Points[0].XValue < removeBefore)
            {
                ptSeries.Points.RemoveAt(0);
            }

            newSeries.LegendText = AlarmViewModels.AlarmList[currentCurve].Description;
            newSeries.Color = (AlarmViewModels.AlarmList[currentCurve].State == StateType.Alarming.ToString() || AlarmViewModels.AlarmList[currentCurve].State == StateType.Responsed.ToString()) ? Color.FromArgb(255, 0, 0) : Color.FromArgb(0, 0, 255);

            chart1.ChartAreas[0].AxisX.Minimum = ptSeries.Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = DateTime.FromOADate(ptSeries.Points[0].XValue).AddSeconds(1).ToOADate();

            chart1.Invalidate();
        }

        //添加时间数据和对应列的值  
        public void AddData()
        {
            DateTime timeStamp = DateTime.Now;

            AddNewPoint(timeStamp, chart1.Series[0]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => currentCurve = comboBox1.SelectedIndex == 0 ? comboBox1.SelectedIndex : comboBox1.SelectedIndex - 1;

        private void timer1_Tick(object sender, EventArgs e) => AddData();
    }
}
