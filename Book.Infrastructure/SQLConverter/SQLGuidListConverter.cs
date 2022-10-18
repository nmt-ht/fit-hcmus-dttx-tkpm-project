namespace EnterpriseLibrary.SQLConverter
{
    /// <summary>
    /// SQLGuidListConverter: Convert Guid value to Byte Array.
    /// </summary>
    [SQLTypeIndicatorAttribute(SQLDataType.Guid)]
    public class SQLGuidListConverter : SQLByteArrayConverter
    {
        private static readonly byte[] NULL_VALUE = Guid.Empty.ToByteArray();
        public SQLGuidListConverter()
            : this(typeof(Guid), 1)
        {
            nullValue = NULL_VALUE;
        }

        public SQLGuidListConverter(Type typeOfElement, int size)
            : base(typeOfElement, size)
        {
            nullValue = nullValue;
        }

        protected override void InsertNull()
        {
            nullValue.CopyTo(byteData, index);
        }

        protected override void InsertObject(object obj)
        {
            ((Guid)obj).ToByteArray().CopyTo(byteData, index);

        }

        protected override bool IsNull(object obj)
        {
            if (((Guid)obj).ToByteArray() == nullValue)
                return true;
            return false;
        }

    }
}
