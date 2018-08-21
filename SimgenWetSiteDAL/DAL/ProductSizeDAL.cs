using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class ProductSizeDAL
    {
        const string TABLE_NAME = "pm_product_size";
        const string FIELDS = "*";

        public bool InsertProductSize(ProductSize productSize)
        {
            productSize.Id = DBHelper<ProductSize>.GetMaxId(TABLE_NAME, "id");
            return DBHelper<ProductSize>.Insert(TABLE_NAME, DBHelper<ProductSize>.GetSim(productSize)) > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ProductSize> GetProductSizeByProductId(string id)
        {
            return DBHelper<ProductSize>.Select(TABLE_NAME, FIELDS, new List<SimpleParameter>() { new SimpleParameter() { Name = "productId", Value = id } });
        }

        public List<ProductSize> GetProductSizeById(string id)
        {
            return DBHelper<ProductSize>.Select(TABLE_NAME, FIELDS, new List<SimpleParameter>() { new SimpleParameter() { Name = "Id", Value = id } });
        }
    }
}
