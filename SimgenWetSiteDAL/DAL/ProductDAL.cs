using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class ProductDAL
    {
        const string TABLE_NAME = "pm_product";
        const string FIELDS = "*";

        /// <summary>
        /// 首页读取创新产品
        /// </summary>
        /// <returns></returns>
        public List<Product> GetNewProduct(int size)
        {
            return DBHelper<Product>.Select(TABLE_NAME, "id,proName,proNo", new List<SimpleParameter>() { 
                new SimpleParameter(){Name = "isNew",Value="1"}
            }, size);//10条创新产品
            
        }

        public List<Product> SearchProduct(string key)
        {
            return DBHelper<Product>.Select(TABLE_NAME, "id,proName,proNo", new List<SimpleParameter>() { 
                new SimpleParameter(){ Sql = String.Format(" and(proName like '%{0}%' or proNo like '%{0}%')", key) }
            }, 500);
 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(int id)
        {
            return GetProductById(id.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(string id)
        {
            return DBHelper<Product>.SelectSingle(
                TABLE_NAME, FIELDS,
                    new SimpleParameter() { Name = "Id", Value = id });
        }

        public List<Product> GetProductByPageHelper(int pageSize, int pageNum)
        {
            string sql = string.Format("with pageTable as(select row_number() over(order by id desc ) rowNumber, * from pm_product)select id,proname,isnew,newdesc,ishot,htmltitle,viewcount,categoryid,tags,doc,doclocal,docmime,docsize,prono,prospecimen,prodesc,relproduct,orderno from pageTable where rowNumber between {0} and {1} ", pageSize * (pageNum - 1) + 1, pageSize * pageNum);
            return DBHelper<Product>.Select(sql);
        }

        //产品没有直接存储类别， 是通过关系关联
        //public List<Product> GetProductByCategoryId(int cateid)
        //{
        //    SimpleParameter s = new SimpleParameter { Name = "Categoryid", Value = cateid };
        //    return DBHelper<Product>.Select(TABLE_NAME, FIELDS, s);
        //}
        public List<Product> GetProductByIds(string ids)
        {
            string sql = string.Format("select * from {0} where id in {1}", TABLE_NAME, ids);
            return DBHelper<Product>.Select(sql);
        }
    }
}
