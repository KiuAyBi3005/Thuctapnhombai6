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
    public partial class FormCustomer : Form
    {
       
        BindingSource CustomerList = new BindingSource();
        public FormCustomer()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            grid_view_customer.DataSource = CustomerList;
            loadCustomerList();
            addBinding();
        }
        void loadCustomerList()
        {

            CustomerList.DataSource = CustomerDAO.Instance.getCustomerList();
        }
        void addBinding()
        {
            edit_text_customer_id.DataBindings.Add(new Binding("Text", grid_view_customer.DataSource, "id", true, DataSourceUpdateMode.Never));
            edit_text_customer_name.DataBindings.Add(new Binding("Text", grid_view_customer.DataSource, "name", true, DataSourceUpdateMode.Never));
            edit_text_customer_phone.DataBindings.Add(new Binding("Text", grid_view_customer.DataSource, "phone", true, DataSourceUpdateMode.Never));
            edit_text_customer_address.DataBindings.Add(new Binding("Text", grid_view_customer.DataSource, "address", true, DataSourceUpdateMode.Never));
        }

        private void button_customer_insert_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                string name = edit_text_customer_name.Text;
                string phone = edit_text_customer_phone.Text;
                string address = edit_text_customer_address.Text;
                if (CustomerDAO.Instance.insertCustomer(name, phone, address))
                {
                    MessageBox.Show("Them thanh cong");
                    loadCustomerList();
                }
            }
            catch
            {
                MessageBox.Show("Them khong thanh cong");
            }
        }

        private void button_customer_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(edit_text_customer_id.Text);
                string name = edit_text_customer_name.Text;
                string phone = edit_text_customer_phone.Text;
                string address = edit_text_customer_address.Text;
                if (CustomerDAO.Instance.updateCustomer(id, name, phone, address))
                {
                    MessageBox.Show("Sua thanh cong");
                    loadCustomerList();
                }
            }
            catch
            {
                MessageBox.Show("Sua khong thanh cong");
            }
        }

        private void button_customer_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(edit_text_customer_id.Text);
                if (CustomerDAO.Instance.deleteCustomer(id))
                {
                    MessageBox.Show("Xoa thanh cong");
                    loadCustomerList();
                }
            }
            catch
            {
                MessageBox.Show("Xoa khong thanh cong");
            }
        }

        private void button_customer_back_Click(object sender, EventArgs e)
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
