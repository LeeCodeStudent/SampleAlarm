using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using Utils;

namespace DAL
{
    public class ManagementDAL
    {
        public static List<ManagementModel> Select()
        {
            string sql = $@"SELECT [ID]
            ,[DutyName]
            ,[DutyTime]
            FROM DutyList";
            DataTable table = DBHelper.GetTable(sql);

            List<ManagementModel> list = new List<ManagementModel>();
            //循环遍历 表中的每一行
            foreach (DataRow row in table.Rows)
            {
                ManagementModel managementModel = new ManagementModel()
                {
                    ID = Convert.ToInt32(row["ID"]),
                    DutyName = Converter.ToTrimedString(row["DutyName"]),
                    //判断读取的是不是数据库中的空值 DBNull.Value
                    //BornDate = row["BornDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["BornDate"])
                    DutyTime = Converter.ToDateTime(row["DutyTime"]),

                };
                list.Add(managementModel);
            }
            return list;
        }

        public static bool Insert(ManagementModel managementModel)
        {
            string sql = $@"insert into DutyList (DutyName, DutyTime) values('{managementModel.DutyName}','{managementModel.DutyTime}')";

            return DBHelper.ExecuteNonQuery_(sql);
        }

        public static int DeleteManagementAll()
        {
            string sql = "delete from DutyList \n DBCC CHECKIDENT ('DutyList', RESEED, 0)";
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int DeleteManagement(int Number)
        {
            string sql1 = $@"delete from DutyList where ID <= ('{ Number }')";
            string sql2 = "select DutyName, DutyTime into # from DutyList order by ID \n truncate table DutyList \n insert into DutyList select *from # \n drop table #";

            int Count = DBHelper.ExecuteNonQuery(sql1);
            DBHelper.ExecuteNonQuery(sql2);
            return Count;
        }
    }
}
