using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Converter
    {
        public static DateTime ToDateTime(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return DateTime.MinValue;
            }
            return Convert.ToDateTime(obj);
        }

        public static int ToInt32(object obj)
        {
            return (obj == null || obj == DBNull.Value) ? 0 : Convert.ToInt32(obj);
        }

        public static string ToString(object obj)
        {
            return (obj == null || obj == DBNull.Value) ? string.Empty : obj.ToString();
        }

        public static string ToTrimedString(object obj)
        {
            return (obj == null || obj == DBNull.Value) ? string.Empty : obj.ToString().Trim();
        }
    }
}
