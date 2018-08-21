using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class HomePageSettingDAL
    {
        const string TABLE_NAME = "sys_homePageSetting";
        const string FIELDS = "*";

        /// <summary>
        /// 获取4列的头部
        /// </summary>
        /// <returns></returns>
        public List<HomePageSetting> GetMainHomePageSetting()
        {
            List<SimpleParameter> simpleParameters = new List<SimpleParameter>();
            simpleParameters.Add(new SimpleParameter() { Name = "isMain", Value = "1" });
            simpleParameters.Add(new SimpleParameter() { Sql = " order by orderNo asc " });
            return DBHelper<HomePageSetting>.Select(TABLE_NAME, FIELDS, simpleParameters);
        }

        public List<HomePageSetting> GetHomePageSetting(List<HomePageSetting> mainSetting)
        {
            string mainIds = "";
            if (mainSetting != null && mainSetting.Count > 0)
            {
                foreach (var item in mainSetting)
                {
                    mainIds += "," + item.Id;
                }
                mainIds = "0" + mainIds;
            }
            List<SimpleParameter> simpleParameters = new List<SimpleParameter>();
            simpleParameters.Add(new SimpleParameter() { Sql = string.Format(" and mainId in({0}) order by orderNo asc ", mainIds) });
            return DBHelper<HomePageSetting>.Select(TABLE_NAME, FIELDS, simpleParameters);
        }
    }
}
