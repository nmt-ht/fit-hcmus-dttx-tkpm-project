using BookManagement.Business;
using BookManagement.Models;
using System.Data;
using System.Reflection;

namespace BookManagement.Client
{
    public partial class RptWHStock : Form
    {
        private readonly IBookStockBiz _bookStockBiz;
        public RptWHStock(IBookStockBiz bookStockBiz)
        {
            InitializeComponent();
            _bookStockBiz = bookStockBiz;
            reportViewer1.LocalReport.ReportEmbeddedResource = "ReportWHStock.rdlc";
            var dataSource = GetDataSource();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("BCTonSachDataset", dataSource));
            reportViewer1.RefreshReport();
        }

        private IList<BookStock> GetDataSource()
        {
            return _bookStockBiz.GetBookStocks().ToList();
        }

        public DataTable ToDataTable()
        {
            List<BookStock> items = new List<BookStock>();
            items = _bookStockBiz.GetBookStocks().ToList();
            var tb = new DataTable(typeof(BookStock).Name);

            PropertyInfo[] props = typeof(BookStock).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                tb.Columns.Add(prop.Name, t);
            }

            foreach (BookStock item in items)
            {
                var values = new object[props.Length];

                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                tb.Rows.Add(values);
            }

            return tb;
        }

        /// <summary>
        /// Determine of specified type is nullable
        /// </summary>
        public static bool IsNullable(Type t)
        {
            return !t.IsValueType || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }

        /// <summary>
        /// Return underlying type if type is Nullable otherwise return the type
        /// </summary>
        public static Type GetCoreType(Type t)
        {
            if (t != null && IsNullable(t))
            {
                if (!t.IsValueType)
                {
                    return t;
                }
                else
                {
                    return Nullable.GetUnderlyingType(t);
                }
            }
            else
            {
                return t;
            }
        }
    }
}
