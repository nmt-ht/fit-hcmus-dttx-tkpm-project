using System.ComponentModel;

namespace BookManagement.Models
{
    public class DataType
    {
        public enum eTypeOfBook
        {
            [Description("Please select type of book")]
            None = -1,
            [Description("Adventure stories")]
            AdventureStories = 0,
            [Description("Classics")]
            Classics = 1,
            [Description("Crime")]
            Crime = 2,
            [Description("Fairy tales, fables, and folk tales")]
            FairyTales = 3,
            [Description("Fantasy")]
            Fantasy = 4,
            [Description("Historical fiction")]
            HistoricalFiction = 5,
            [Description("Horror")]
            Horror = 6,
            [Description("Humour and satire")]
            HumourandSatire = 7,
            [Description("Literary fiction")]
            LiteraryFiction = 8,
            [Description("Mystery")]
            Mystery = 9,
            [Description("Poetry")]
            Poetry = 10,
            [Description("Plays")]
            Plays = 11,
            [Description("Romance")]
            Romance = 12,
            [Description("Science fiction")]
            ScienceFiction = 12,
            [Description("Short stories")]
            ShortStories = 13,
            [Description("Thrillers")]
            Thrillers = 14,
            [Description("War")]
            War = 15,
            [Description("Women’s fiction")]
            WomenFiction = 16,
            [Description("Young adult")]
            YoungAdult = 17,
            [Description("Biography")]
            Biography = 18
        }

        public enum eGender
        {
            Unknown = 0,
            Male = 1,
            Female = 2
        }

        public enum eUserType
        {
            Admin = 0,
            User = 1
        }

        public enum eReceiptStatus
        {
            Unpaid = 0,
            Paid = 1
        }

        public enum eParameterType
        {
            Book = 1,
            Customer = 2,
            Inventory = 3
        }

        public enum eAddressType
        {
            Primary = 0,
            Other = 1
        }
    }
}
