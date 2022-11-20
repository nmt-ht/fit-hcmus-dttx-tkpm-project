using BookManagement.Business;
using BookManagement.Models;
using System.Data;
using System.Reflection;

namespace BookManagement.Client
{
    public partial class RptWHStock : Form
    {
        private readonly IInventorySnapshotBiz _inventorySnapshotBiz;
        public RptWHStock(IInventorySnapshotBiz inventorySnapshotBiz)
        {
            InitializeComponent();
            _inventorySnapshotBiz = inventorySnapshotBiz;
            reportViewer1.LocalReport.ReportEmbeddedResource = "BookManagement.Client.Report.ReportWHStock.rdlc";
            var dataSource = GetDataSource();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("BCTonSachDataset", dataSource));
            reportViewer1.RefreshReport();
        }

        private IList<InventorySnapshot> GetDataSource()
        {
            return _inventorySnapshotBiz.GetInventorySnapshots().ToList();
        }

        public DataTable ToDataTable()
        {
            List<InventorySnapshot> items = new List<InventorySnapshot>();
            items = _inventorySnapshotBiz.GetInventorySnapshots().ToList();
            var tb = new DataTable(typeof(InventorySnapshot).Name);

            PropertyInfo[] props = typeof(InventorySnapshot).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                tb.Columns.Add(prop.Name, t);
            }

            foreach (InventorySnapshot item in items)
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
