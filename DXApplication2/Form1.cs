using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraTabbedMdi;
using DevExpress.XtraTab;
using LibraryDatabase;
using DevExpress.XtraGrid;


namespace DXApplication2
{
    public partial class Form1 : XtraForm
    {
        #region Properties
        public LibraryDbContext Db { get; set; }
        #endregion

        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
            Db = new LibraryDbContext();

            DbHelper.FillGrid<Book>(gridBooks, Db.Books);
            DbHelper.FillGrid<Author>(gridAuthors, Db.Authors);
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(iSkins, true);
        }

        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("ნამდვილად გსურთ გასვლა?", "გასვლა", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}