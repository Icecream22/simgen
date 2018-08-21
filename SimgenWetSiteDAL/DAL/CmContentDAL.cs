using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class CmContentDAL
    {
        private const string tableName = "cm_content";
        public CmContent GetContentById(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "id", Value = id };
            return DBHelper<CmContent>.SelectSingle(tableName, "*", s);
        }
        
        public List<CmContent> GetContentByCateId(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "cateId", Value = id };
            return DBHelper<CmContent>.Select(tableName, "*", s);
        }


        public CmContent GetContentByCateIdAndId(int cateId, int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "cateId", Value = cateId };
            SimpleParameter s1 = new SimpleParameter { Name = "id", Value = id };
            
            return DBHelper<CmContent>.SelectSingle(tableName, "*", new List<SimpleParameter>(){s,s1});
        }

        public List<CmContent> GetContent()
        {
            return DBHelper<CmContent>.Select(tableName, "*");
        }
    }
}
