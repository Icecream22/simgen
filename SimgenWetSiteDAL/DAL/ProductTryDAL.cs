using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;
using SimgenWebSiteDAL.Help;

namespace SimgenWebSiteDAL.DAL
{
    public class ProductTryDAL
    {
        private const string tableName = "pm_product_try";
        private const string Fields = "*";
        public bool Insert(ProductTry productTry)
        {
            productTry.Id = DBHelper<ProductTry>.GetMaxId(tableName, "id");
            List<SimpleParameter> list = new List<SimpleParameter>();
            list = DBHelper<ProductTry>.GetSim(productTry);
            return DBHelper<object>.Insert(tableName, list) > 0;
        }

        public ProductTry GetTryById(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "id", Value = id };
            return DBHelper<ProductTry>.SelectSingle(tableName, Fields, s);
        }
        public List<ProductTry> GetTryByMemberId(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "memberId", Value = id };
            return DBHelper<ProductTry>.Select(tableName, Fields, s);
        }
        public List<ProductTry> GetTryByProductId(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "productId", Value = id };
            return DBHelper<ProductTry>.Select(tableName, Fields, s);
        }
        /// <summary>
        /// 根据用户id，商品id，和尺寸id来判断是否存在此数据
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="productId"></param>
        /// <param name="sizeId"></param>
        /// <returns></returns>
        public bool GetTryByMemberIdAndProductId(int memberId, int productId)
        {
            List<SimpleParameter> list = new List<SimpleParameter>();
            SimpleParameter s = new SimpleParameter { Name = "memberId", Value = memberId };
            SimpleParameter s1 = new SimpleParameter { Name = "productId", Value = productId };
            list.Add(s);
            list.Add(s1);
            ProductTry p = DBHelper<ProductTry>.SelectSingle(tableName, Fields, list);
            if (p != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
