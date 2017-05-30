using QuanLySieuThi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DAO
{
    class EmployyDAO
    {
        private static EmployyDAO instance;

        public static EmployyDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployyDAO();
                return EmployyDAO.instance;
            }

            private set
            {
                EmployyDAO.instance = value;
            }
        }

        private EmployyDAO() { }

        public List<Employy> getEmployyList()
        {
            List<Employy> list = new List<Employy>();
            string query = " select * from employy ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Employy employy = new Employy(item);
                list.Add(employy);
            }
            return list;
        }

        public bool insertEmployy(string name, string phone, string address)
        {
            string query = "Insert into dbo.Employy(name,phone,address) values ('" + name + "'," + phone + ",'" + address + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateEmployy(int id, string name, string phone, string address)
        {
            string query = string.Format(" update Employy set name = N'{0}', phone = '{1}',  address = '{2}' where id = '{3}'", name, phone, address, id);
            int relust = DataProvider.Instance.ExecuteNonQuery(query);
            return relust > 0;
        }

        public bool deleteEmployy(int id)
        {
            string query = string.Format("delete from Employy where id = '{0}'", id);
            int relust = DataProvider.Instance.ExecuteNonQuery(query);
            return relust > 0;
        }
    }
}
