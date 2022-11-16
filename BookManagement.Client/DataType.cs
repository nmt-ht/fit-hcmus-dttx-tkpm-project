namespace BookManagement.Client
{
    public static class DataType
    {
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
        
        public enum eTypeOfAddBook
        {
            New = 0,
            Existed = 1
        }

        public enum eLayoutType
        {
            Book = 0,
            Customer = 1,
            Receipt = 2
        }
    }
}
