using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class AlarmHistoryBLL
    {
        public static List<AlarmHistoryModel> GetHistoryViewModel() => AlarmHistoryDAL.GetAlarmHistory();

        public static int DeleteAllHistory() => AlarmHistoryDAL.DeleteAlarmAll();
    }
}
