using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 管理员数据访问类
    /// </summary>
    public class AdminDAL
    {
        public static List<AdminsModel> Select()
        {
            string sql = @"SELECT [LoginID]
            ,[LoginPwd]
            FROM Admins";
            DataTable table = DBHelper.GetTable(sql);

            List<AdminsModel> list = new List<AdminsModel>();
            //循环遍历 表中的每一行
            foreach (DataRow row in table.Rows)
            {
                AdminsModel admin = new AdminsModel()
                {
                    LoginID = row["LoginID"].ToString().Trim(),
                    LoginPwd = row["LoginPwd"].ToString().Trim(),
                };
                list.Add(admin);
            }
            return list;
        }
        public static AdminsModel Find(string column, object value)
        {
            string sql = $@"select [LoginID]
            ,[LoginPwd]
            from Admins where {column} = '{value}'";

            SqlDataReader reader = DBHelper.ExecuteReader(sql);

            try
            {

                if (reader != null)
                {
                    if (reader.HasRows)     //判断是不是有数
                    {
                        if (reader.Read())  //只读取第一行满足条件的数据
                        {
                            AdminsModel admin = new AdminsModel()
                            {
                                LoginID = reader["LoginID"].ToString().Trim(),
                                LoginPwd = reader["LoginPwd"].ToString().Trim(),
                            };

                            return admin;
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
