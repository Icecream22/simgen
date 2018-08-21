using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class CategoryProductDAL
    {
        private const string tableName = "pm_category_product";
        public List<CategoryProduct> GetCategoryByProductId(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "productid", Value = id };
            return DBHelper<CategoryProduct>.Select(tableName, "*", s);
        }

        public List<CategoryProduct> GetProductByCategoryId(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "cateid", Value = id };
            return DBHelper<CategoryProduct>.Select(tableName, "*", s);
        }

    }
}
