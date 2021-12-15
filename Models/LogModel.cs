using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public delegate void SendMessageEventHandler(LogModel e);

    public delegate void ReceiveMessageEventHandler(LogModel e);

    //打印日志记录
    public class LogModel
    {
        public event SendMessageEventHandler SendMessageChanged;

        public event ReceiveMessageEventHandler ReceiveMessageChanged;

        private string sendMessage;
        public string SendMessage
        {
            get { return sendMessage; }
            set
            {
                sendMessage = value;
                SendMessageChanged.Invoke(this);
            }
        }

        private string receiveMessage;
        public string ReceiveMessage
        {
            get { return receiveMessage; }
            set
            {
                receiveMessage = value;
                ReceiveMessageChanged.Invoke(this);
            }
        }
    }
}
