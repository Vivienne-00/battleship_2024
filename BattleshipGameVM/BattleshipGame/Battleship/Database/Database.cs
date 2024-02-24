namespace Battleship.Database
{
    public class Database
    {
        private Database() { }
        private static Database _instance;
        public static Database GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Database();
            }
            return _instance;
        }

        // Finally, any singleton should define some business logic, which can
        // be executed on its instance.
        public void someBusinessLogic()
        {

        }
    }
}
