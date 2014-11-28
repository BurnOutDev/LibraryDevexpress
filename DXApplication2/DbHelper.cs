using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System.Data.Linq;
using LibraryDatabase;


namespace DXApplication2
{
    public static class DbHelper
    {
        public static void FillGrid<T>(GridControl grid, Table<T> entity) where T : class
        {
            grid.DataSource = entity.ToList();
        }
    }
}
