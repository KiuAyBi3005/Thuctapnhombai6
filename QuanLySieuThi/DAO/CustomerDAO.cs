using QuanLySieuThi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DAO
{
    class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return CustomerDAO.instance;
            }

            private set
            {
                CustomerDAO.instance = value;
            }
        }

        private CustomerDAO() { }

        public List<Customer> getCustomerList()
        {
            List<Customer> list = new List<Customer>();
            string query = " select * from Customer ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }
            return list;
        }

        public bool insertCustomer(string name, string phone, string address)
        {
            string query = "Insert into dbo.Customer(name,phone,address) values ('" + name + "'," + phone + ",'" + address + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateCustomer(int id, string name, string phone, string address)
        {
            string query = string.Format(" update Customer set name = N'{0}', phone = '{1}',  address = '{2}' where id = '{3}'", name, phone, address, id);
            int relust = DataProvider.Instance.ExecuteNonQuery(query);
            return relust > 0;
        }

        public bool deleteCustomer(int id)
        {
            string query = string.Format("delete from Customer where id = '{0}'", id);
            int relust = DataProvider.Instance.ExecuteNonQuery(query);
            return relust > 0;
        }
    }
}
