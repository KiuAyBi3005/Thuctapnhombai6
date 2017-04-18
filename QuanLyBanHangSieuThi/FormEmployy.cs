using QuanLyBanHangSieuThi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangSieuThi
{
    public partial class FormEmployy : Form
    {
        public FormEmployy()
        {
            InitializeComponent();
            LoadingEmployyList();
        }

        void LoadingEmployyList()
        {
            string query = "Select * from dbo.Employy";
            DataProvider provider = new DataProvider();
            gird_view_employy.DataSource = provider.ExecuteQuery(query);



        }

        
    }
} 
