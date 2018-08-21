using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class SolutionDAL
    {
        const string TABLE_NAME = "pm_solution";
        const string FIELDS = "*";

        public List<Solution> GetHomeSolution()
        {
            List<SimpleParameter> simpleParameters = new List<SimpleParameter>();
            simpleParameters.Add(new SimpleParameter() { Sql = " order by orderNo asc " });
            return DBHelper<Solution>.Select(TABLE_NAME, FIELDS, simpleParameters);
        }
        public Solution GetSolutionById(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "id", Value = id };
            return DBHelper<Solution>.SelectSingle(TABLE_NAME, FIELDS, s);
        }
    }
}
