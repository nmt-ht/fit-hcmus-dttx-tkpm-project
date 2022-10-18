using System.Collections;

namespace EnterpriseLibrary.SQLConverter
{
    /// <summary>
    /// SQLConverter convert Value Type to Byte Array
    /// </summary>
    public abstract class SQLByteArrayConverter
    {
        protected Byte[] nullValue;
        protected int sizeOfElement = 0;
        protected Type elementType;

        protected int length;
        protected byte[] byteData;
        protected int index = 1;

        protected SQLByteArrayConverter(Type type, int size)
        {
            this.elementType = type;

            this.sizeOfElement = this.GetSizeOfElement();

            //Store the mark attribute
            length = size * sizeOfElement + 1;

            //Init data source
            byteData = new byte[length];

            //Get Indicator attribute
            object[] fbstias = this.GetType().GetCustomAttributes(typeof(SQLTypeIndicatorAttribute), false);
            if (fbstias.Length != 1)
                throw new ApplicationException("Expected 1 FirstByteSQLTypeIndicator attribute on the '" + this.GetType().Name + "' class but got " + fbstias.Length.ToString() + ".");

            //Mark the data
            byteData[0] = Convert.ToByte(((SQLTypeIndicatorAttribute)fbstias[0]).SqlTypeIndicator);
        }

        /// <summary>
        /// Creates and returns a byte array list to be passed to a stored procedure as an image. The internal state of the SQLListCreator maintained. If you have no intention of adding more items to the list, after this method call, use GetListAndReset instead.
        /// </summary>
        /// <returns>Byte array to be passed to a stored procedure as an image sql parameter.</returns>
        public virtual byte[] ToByteArray()
        {
            byte[] returnArray = new byte[index];
            Array.Copy(byteData, returnArray, index);
            return returnArray;
        }

        private unsafe int GetSizeOfElement()
        {
            int result = 0;
            if (elementType.IsValueType)
            {
                if (elementType == typeof(Guid))
                {
                    result = sizeof(Guid);
                }

            }
            return result;
        }

        public void AddValue(object obj)
        {
            CheckArrayBounds(sizeOfElement);

            if (IsNull(obj))
                InsertNull();
            else
                InsertObject(obj);

            index += sizeOfElement;
        }

        protected virtual void InsertNull()
        {
        }

        protected virtual void InsertObject(object obj)
        {
        }

        protected virtual bool IsNull(object obj)
        {
            return false;
        }

        private void CheckArrayBounds(int incrementSize)
        {
            if (index + incrementSize > length)
            {
                length = (index + incrementSize) * 2;
                byte[] temp = new byte[length];
                byteData.CopyTo(temp, 0);
                byteData = temp;
            }
        }
        public virtual byte[] ConvertToByteArray(IList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                this.AddValue(list[i]);
            }
            return this.ToByteArray();
        }
    }

    /// <summary>
    /// SQL Data Type
    /// </summary>
    public enum SQLDataType
    {
        Unknown = 0,
        Guid = 1
    }

    /// <summary>
    /// First Byte SQLType Indicator Attribute
    /// </summary>
    internal class SQLTypeIndicatorAttribute : Attribute
    {
        private SQLDataType sqlTypeIndicator = SQLDataType.Unknown;

        public SQLTypeIndicatorAttribute(SQLDataType sqlTypeIndicator)
        {
            this.sqlTypeIndicator = sqlTypeIndicator;
        }

        public SQLDataType SqlTypeIndicator
        {
            get
            {
                return sqlTypeIndicator;
            }
        }
    }
}
