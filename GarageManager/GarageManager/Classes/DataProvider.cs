using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Classes
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            set { instance = value; }
        }
        public Model.GarageManagementEntities DB { get; set; }
        private DataProvider()
        {
            DB = new Model.GarageManagementEntities();
        }
    }
}
