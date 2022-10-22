namespace BookManagement.Client
{
    public static class DataType
    {
        public enum eDashboard
        {
            Home = 0,
            Books = 1,
            Employee = 2,
            Customer = 3,
            Invoice = 4,
            Report = 5,
            Setting = 6
        }
        public enum eAction
        {
            Add = 0,
            Edit = 1,
            Delete = 2,
        }
        public enum eObjectType
        {
            Book = 0,
            User = 1
        }

        public enum eMessageType 
        { 
            Info = 0,
            Warning = 1
        } 
    }
}
