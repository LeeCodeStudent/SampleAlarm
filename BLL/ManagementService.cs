using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class ManagementService
    {
        public static List<ManagementModel> GetManagementModel() =>ManagementDAL.Select();

        public static bool CreateManagement(ManagementModel model) => ManagementDAL.Insert(model);

        public static int RemoveAllManagementHistory() => ManagementDAL.DeleteManagementAll();

        public static int RemoveManagementHistory(int Number) => ManagementDAL.DeleteManagement(Number);
    }
}
