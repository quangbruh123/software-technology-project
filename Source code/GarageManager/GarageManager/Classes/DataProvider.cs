namespace GarageManager.Classes
{
    /// <summary>
    /// Handles the data. This is the pivotal class
    /// </summary>
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
