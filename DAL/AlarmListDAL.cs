using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using Utils;
using ViewModels;
using System.Data.SqlClient;

namespace DAL
{
    public class AlarmListDAL
    {
        //如果DataGridView中只需要表中的部分列，可以随时删除不需要的数据
        public void Select()
        {
            string sql = $@"SELECT [ID]
            ,[NAME]
            ,[DESCRIPTION]
            ,[VALUE]
            ,[Unit]
            ,[STATE]
            ,[LoLoAlarm]
            ,[LowAlarm]
            ,[HighAlarm]
            ,[HiHiAlarm]
            ,[UTC]
            FROM VariableDB";
            DataTable table = DBHelper.GetTable(sql);

            List<AlarmListModel> list = new List<AlarmListModel>();
            //循环遍历 表中的每一行
            foreach (DataRow row in table.Rows)
            {
                AlarmListModel alarmList = new AlarmListModel()
                {
                    ID = Converter.ToInt32(row["ID"]),
                    Name = Converter.ToTrimedString(row["Name"]),
                    Description = Converter.ToTrimedString(row["Description"]),
                    Value = Converter.ToInt32(row["Value"]),
                    Unit = Converter.ToTrimedString(row["Unit"]),
                    State = Converter.ToTrimedString(row["State"]),
                    LoLoAlarm = Converter.ToInt32(row["LoLoAlarm"]),
                    LowAlarm = Converter.ToInt32(row["LowAlarm"]),
                    HighAlarm = Converter.ToInt32(row["HighAlarm"]),
                    HiHiAlarm = Converter.ToInt32(row["HiHiAlarm"]),
                    UTC = Converter.ToDateTime(row["UTC"]),
                };
                alarmList.ValueChanged += AlarmListBLL_ValueChanged;
                AlarmViewModels.AlarmList.Add(alarmList);
            }
        }

        private static object sync = new object();

        private void AlarmListBLL_ValueChanged(AlarmListModel e)
        {
            Console.WriteLine(e.State);

            // 新增报警
            AlarmHistoryModel model = new AlarmHistoryModel()
            {
                ID = e.ID,
                Name = e.Name,
                Description = e.Description,
                State = e.State,
                Value = e.Value,
                Unit = e.Unit,
                UTC = DateTime.Now
            };
            // 加一个线程锁
            lock (sync)
            {
                AlarmHistoryDAL.InsertAlarmHistory(model);
            }
        }

        public static bool Update(AlarmListModel alarmList)
        {
            string sql = $@"update VariableDB Set LoLoAlarm ='{alarmList.LoLoAlarm}',LowAlarm = '{alarmList.LowAlarm}',HighAlarm = '{alarmList.HighAlarm}',HiHiAlarm = '{alarmList.HiHiAlarm}' where ID='{alarmList.ID}'";
            return DBHelper.ExecuteNonQuery_(sql);
        }
        public static AlarmListModel Find(string column, object value)
        {
            #region 参数化 SQL 语句

            string sql = $@"select ID ,LoLoAlarm, LowAlarm, HighAlarm, HiHiAlarm from VariableDB where {column} = @value";
            SqlParameter[] parasFind =
            {
                        new SqlParameter("@value",value),
            };
            SqlDataReader reader = DBHelper.ExecuteReader(sql, parasFind);

            #endregion

            try
            {
                if (reader != null)
                {
                    if (reader.HasRows)     //判断是不是有数
                    {
                        if (reader.Read())  //只读取第一行满足条件的数据
                        {
                            AlarmListModel model = new AlarmListModel()
                            {
                                ID = Converter.ToInt32(reader["ID"]),
                                LoLoAlarm = Converter.ToInt32(reader["LoLoAlarm"]),
                                LowAlarm = Converter.ToInt32(reader["LowAlarm"]),
                                HighAlarm = Converter.ToInt32(reader["HighAlarm"]),
                                HiHiAlarm = Convert.ToInt32(reader["HiHiAlarm"]),
                            };

                            return model;
                        }
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                reader.Close();
            }
        }

    }
}
