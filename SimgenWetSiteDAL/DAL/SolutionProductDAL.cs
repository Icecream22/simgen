using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class SolutionProductDAL
    {
        private const string tableName = "pm_solution_product";
        public List<ProductSolution> GetSolutionByProductId(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "productId", Value = id };
            //string sql = string.Format("select * from pm_solution_product where productId = {0}", id);
            return DBHelper<ProductSolution>.Select(tableName, "*", s);
        }

        public ProductSolution GetSolutionById(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "id", Value = id };
            return DBHelper<ProductSolution>.SelectSingle(tableName, "*", s);
        }

        public List<ProductSolution> GetProductIdsBySolutionId(int solutionId)
        {
            SimpleParameter s = new SimpleParameter { Name = "psId", Value = solutionId };
            return DBHelper<ProductSolution>.Select(tableName, "*", s);
        }
    }
}
