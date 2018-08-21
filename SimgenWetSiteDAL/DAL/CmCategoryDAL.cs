using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class CmCategoryDAL
    {
        private const string tableName = "cm_category";
        public CmCategory GetCategoryById(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "id", Value = id };
            return DBHelper<CmCategory>.SelectSingle(tableName, "*", s);
        }
        public List<CmCategory> GetCategory()
        {
            return DBHelper<CmCategory>.Select(tableName, "*");
        }
    }
}
