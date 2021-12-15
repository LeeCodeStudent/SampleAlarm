using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Models
{
    //产生报警执行写入数据库操作
    public delegate void ValueChangedEventHandler(AlarmListModel e);

    public class AlarmListModel
    {
        public event ValueChangedEventHandler ValueChanged;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                if (Value != value)
                {
                    if (value <= LoLoAlarm)
                    { Message = Description + "极低"; State = StateType.Alarming.ToString(); }
                    else if (value < LowAlarm)
                    { Message = Description + "过低"; State = StateType.Alarming.ToString(); }
                    else if (value > HighAlarm)
                    { Message = Description + "过高"; State = StateType.Alarming.ToString(); }
                    else if (value > HiHiAlarm)
                    { Message = Description + "极高"; State = StateType.Alarming.ToString(); }
                    else
                    { Message = Description + "正常"; State = StateType.Nomal.ToString(); };
                    _value = value;
                }
            }
        }
        public string Unit { get; set; }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private string _state;
        public string State
        {
            get { return _state; }
            set
            {
                if (State != value)
                {
                    if (State == StateType.Responsed.ToString() && value == StateType.Alarming.ToString())
                    {
                        return;
                    }
                    else
                    {
                        _state = value;
                        this.ValueChanged?.BeginInvoke(this, null, null);
                    }
                }
            }
        }
        public int LoLoAlarm { get; set; }
        public int LowAlarm { get; set; }
        public int HighAlarm { get; set; }
        public int HiHiAlarm { get; set; }
        public DateTime UTC { get; set; }
    }
}
