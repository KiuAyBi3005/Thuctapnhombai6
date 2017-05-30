using QuanLySieuThi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLySieuThi
{
    public partial class FormEmployy : Form
    {
        BindingSource employyList = new BindingSource();
        public FormEmployy()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            grid_view_employy.DataSource = employyList;
            loadEmployyList();
            addBinding();
        }
        void loadEmployyList()
        {
        
            employyList.DataSource = EmployyDAO.Instance.getEmployyList();
        }
        void addBinding()
        {
            edit_text_employy_id.DataBindings.Add(new Binding("Text", grid_view_employy.DataSource, "id", true, DataSourceUpdateMode.Never));
            edit_text_employy_name.DataBindings.Add(new Binding("Text", grid_view_employy.DataSource, "name", true, DataSourceUpdateMode.Never));
            edit_text_employy_phone.DataBindings.Add(new Binding("Text", grid_view_employy.DataSource, "phone", true, DataSourceUpdateMode.Never));
            edit_text_employy_address.DataBindings.Add(new Binding("Text", grid_view_employy.DataSource, "address", true, DataSourceUpdateMode.Never));
        }

        private void button_employy_insert_Click(object sender, EventArgs e)
        {
            try
            {
                string name = edit_text_employy_name.Text;
                string phone = edit_text_employy_phone.Text;
                string address = edit_text_employy_address.Text;
                if (EmployyDAO.Instance.insertEmployy(name, phone, address))
                {
                    MessageBox.Show("Them thanh cong");
                    loadEmployyList();
                }
            }
            catch
            {
                MessageBox.Show("Them khong thanh cong");
            }

        }

        private void button_employy_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(edit_text_employy_id.Text);
                string name = edit_text_employy_name.Text;
                string phone = edit_text_employy_phone.Text;
                string address = edit_text_employy_address.Text;
                if (EmployyDAO.Instance.updateEmployy(id, name, phone, address))
                {
                    MessageBox.Show("Sua thanh cong");
                    loadEmployyList();
                }
            }
            catch
            {
                MessageBox.Show("Sua khong thanh cong");
            }

        }

        private void button_employy_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(edit_text_employy_id.Text);
                if (EmployyDAO.Instance.deleteEmployy(id))
                {
                    MessageBox.Show("Xoa thanh cong");
                    loadEmployyList();
                }
            }
            catch
            {
                MessageBox.Show("Xoa khong thanh cong");
            }

        }

        private void button_employy_back_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
