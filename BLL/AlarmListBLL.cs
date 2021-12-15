using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
using Utils;
using ViewModels;
using Collector.Communication.Modbus.TCP;

namespace BLL
{
    public class AlarmListBLL
    {
        private ModbusTCP _modbusTCP;

        private AlarmListDAL _alarmListDAL;

        private string IP { get; set; }
        private int Port { get; set; }

        public AlarmListBLL(string IP, int Port)
        {
            _modbusTCP = new ModbusTCP();

            _alarmListDAL = new AlarmListDAL();

            this.IP = IP;
            this.Port = Port;
        }
        public void GetAlarmListModel() => _alarmListDAL.Select();

        public async Task Refresh()
        {
            ushort[] res = new ushort[AlarmViewModels.AlarmList.Count];
            _modbusTCP.Connect(this.IP, this.Port);
            res = await _modbusTCP.ReadHoldingRegisters(1, 0, (ushort)AlarmViewModels.AlarmList.Count);
            for (int i = 0; i < AlarmViewModels.AlarmList.Count; i++)
            {
                AlarmViewModels.AlarmList[i].Value = res[i];
            }
        }

        public static bool UpdataLimit(AlarmListModel model) => AlarmListDAL.Update(model);

        public static AlarmListModel GetModelByID(string ID) => AlarmListDAL.Find("ID", ID);
    }
}
