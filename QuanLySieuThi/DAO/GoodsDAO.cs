using QuanLySieuThi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DAO
{
    public class GoodsDAO
    {
        private static GoodsDAO instance;
        public static GoodsDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GoodsDAO();
                return GoodsDAO.instance;
            }
            private set
            {
                GoodsDAO.instance = value;
            }
        }
        private GoodsDAO() { }
        public List<Goods> getListGoods()
        {
            List<Goods> list = new List<Goods>();
            string query = "";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Goods goods = new Goods(item);
                list.Add(goods); 
            }
            return list;
        }
    }
    
}
