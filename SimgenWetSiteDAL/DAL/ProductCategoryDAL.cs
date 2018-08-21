using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class ProductCategoryDAL
    {

        const string TABLE_NAME = "pm_category";
        const string FIELDS = "*";

        /// <summary>
        /// 获取产品大类
        /// </summary>
        /// <returns></returns>
        public List<PmCategory> GetBigCategory()
        {
            List<SimpleParameter> simpleParameters = new List<SimpleParameter>();
            simpleParameters.Add(new SimpleParameter() { Name = "parentId", Value = "0" });
            simpleParameters.Add(new SimpleParameter() { Sql = " order by orderNo asc " });
            return DBHelper<PmCategory>.Select(TABLE_NAME, FIELDS, simpleParameters);
        }

        /// <summary>
        /// 获取指定类别的子类
        /// </summary>
        /// <param name="mainSetting"></param>
        /// <returns></returns>
        public List<PmCategory> GetSonCategory(List<PmCategory> bigCategory)
        {
            string parentIds = "";
            if (bigCategory != null && bigCategory.Count > 0)
            {
                foreach (var item in bigCategory)
                {
                    parentIds += "," + item.Id;
                }
                parentIds = "0" + parentIds;
            }
            List<SimpleParameter> simpleParameters = new List<SimpleParameter>();
            simpleParameters.Add(new SimpleParameter() { Sql = string.Format(" and parentId in({0}) order by orderNo asc ", parentIds) });
            return DBHelper<PmCategory>.Select(TABLE_NAME, FIELDS, simpleParameters);
        }
        /// <summary>
        /// 获取指定类别的子类
        /// </summary>
        /// <param name="mainSetting"></param>
        /// <returns></returns>
        public List<PmCategory> GetSonCategory(int id)
        {
            List<SimpleParameter> simpleParameters = new List<SimpleParameter>();
            simpleParameters.Add(new SimpleParameter() { Name = "parentId", Value = id });
            return DBHelper<PmCategory>.Select(TABLE_NAME, FIELDS, simpleParameters);
        }

        public PmCategory GetCategoryById(int id)
        {
            List<SimpleParameter> simpleParameters = new List<SimpleParameter>();
            simpleParameters.Add(new SimpleParameter() { Name = "Id", Value = id });
            return DBHelper<PmCategory>.SelectSingle(TABLE_NAME, FIELDS, simpleParameters);
        }

    }

}
