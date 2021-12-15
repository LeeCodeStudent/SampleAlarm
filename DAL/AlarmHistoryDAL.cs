using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Utils;
using System.Data;

namespace DAL
{
    public class AlarmHistoryDAL
    {
        public static List<AlarmHistoryModel> GetAlarmHistory()
        {
            string sql = $@"SELECT [AlarmIndex]
            ,[ID]
            ,[Name]
            ,[Description]
            ,[State]
            ,[Value]
            ,[Unit]
            ,[UTC]
            FROM AlarmHistory order by AlarmIndex DESC";
            DataTable table = DBHelper.GetTable(sql);

            List<AlarmHistoryModel> list = new List<AlarmHistoryModel>();
            //循环遍历 表中的每一行
            foreach (DataRow row in table.Rows)
            {
                AlarmHistoryModel alarmHistory = new AlarmHistoryModel()
                {
                    AlarmIndex = Convert.ToInt32(row["AlarmIndex"]),
                    ID = Converter.ToInt32(row["ID"]),
                    Name = Converter.ToTrimedString(row["Name"]),
                    Description = Converter.ToTrimedString(row["Description"]),
                    State = Converter.ToTrimedString(row["State"]),
                    Value = Converter.ToInt32(row["Value"]),
                    Unit = Converter.ToTrimedString(row["Unit"]),
                    UTC = Converter.ToDateTime(row["UTC"]),

                };
                list.Add(alarmHistory);
            }
            return list;
        }

        /// <summary>
        /// 添加报警记录
        /// </summary>
        /// <param name="historyViewModel"></param>
        /// <returns></returns>
        public static bool InsertAlarmHistory(AlarmHistoryModel historyModel)
        {
            string sql = $@"insert into AlarmHistory values('{historyModel.ID}','{historyModel.Name}','{historyModel.Description}','{historyModel.State}','{historyModel.Value}','{historyModel.Unit}','{historyModel.UTC}')";

            return DBHelper.ExecuteNonQuery_(sql);
        }

        public static int DeleteAlarmAll()
        {
            string sql = "delete from AlarmHistory \n DBCC CHECKIDENT ('AlarmHistory', RESEED, 0)";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public static int DeleteAlarm(int Number)
        {
            string sql1 = $@"delete from AlarmHistoryList where AlarmIndex <= ('{ Number }')";
            string sql2 = "select ID, DESCRIPTION,STATE,MESSAGE,VALUE,UTC into # from AlarmHistoryList order by AlarmIndex \n truncate table AlarmHistoryList \n insert into AlarmHistoryList select * from # \n drop table #";
            int Count = DBHelper.ExecuteNonQuery(sql1);
            DBHelper.ExecuteNonQuery(sql2);
            return Count;
        }
    }
}
