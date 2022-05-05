using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Classes
{
    public class DataProvider
    {
        private DataProvider instance;
        public DataProvider Instance
        {
            get { return instance; }
            set { instance = value; }
        }
    }
}
