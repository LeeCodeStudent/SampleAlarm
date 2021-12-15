using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public static class AdminService
    {
        public static int Login(string id, string pwd)
        {
            AdminsModel admins = AdminDAL.Find("LoginID", id);
            if (admins == null)
            {
                //账号错误
                return 0;
            }
            else if(admins.LoginPwd != pwd)
            {
                //密码错误
                return 1;
            }
            else
            {
                //账号密码正确
                return 2;
            }
        }
    }
}
