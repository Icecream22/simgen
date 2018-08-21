using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{

    public enum AdvPosition
    {
        /// <summary>
        /// 首页
        /// </summary>
        Home = 1,
        /// <summary>
        /// 产品页
        /// </summary>
        Product = 2,
        /// <summary>
        /// 促销页
        /// </summary>
        Promotion = 3,
        /// <summary>
        /// 全站侧边
        /// </summary>
        Side = 4
    }

    public class AdvDAL
    {
        const string TABLE_NAME = "act_ad";
        const string FIELDS = "*";

        public List<Adv> GetHomeAdvs()
        {
            return GetAdvs(AdvPosition.Home);
        }
        public List<Adv> GetProductAdvs()
        {
            return GetAdvs(AdvPosition.Product);
        }
        public List<Adv> GetPromotionAdvs()
        {
            return GetAdvs(AdvPosition.Promotion);
        }
        public List<Adv> GetSideAdvs()
        {
            return GetAdvs(AdvPosition.Side);
        }
        public List<Adv> GetAdvs(AdvPosition pos)
        {
            List<SimpleParameter> simpleParameters = new List<SimpleParameter>();
            simpleParameters.Add(new SimpleParameter() { Name = "isEnable", Value = "1" });
            simpleParameters.Add(new SimpleParameter() { Name = "adPosition", Value = ((int)pos).ToString() });
            return DBHelper<Adv>.Select(TABLE_NAME, FIELDS, simpleParameters);
        }
    }
}
