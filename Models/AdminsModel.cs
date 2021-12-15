using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 管理员类
    /// </summary>
    public class AdminsModel
    {
        /// <summary>
        /// 管理员登陆账号
        /// </summary>
        public string LoginID { set; get; }


        /// <summary>
        /// 管理员登陆密码
        /// </summary>
        public string LoginPwd { set; get; }
    }
}
