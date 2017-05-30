using QuanLySieuThi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return BillInfoDAO.instance;
            }
            private set
            {
                BillInfoDAO.instance = value;
            }
           
        }
        private BillInfoDAO() { }

        internal List<BillInfo> getListBillInfo(List<Bill> list)
        {
            throw new NotImplementedException();
        }

        public List<BillInfo> getListBillInfo(int id)
        {
            List<BillInfo> list = new List<BillInfo>();
           
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.BillInfo where idBill =" + id);
            foreach (DataRow item in data.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                list.Add(billInfo);
            }
            return list;
        }

    }
}
