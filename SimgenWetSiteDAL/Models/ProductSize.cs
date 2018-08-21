using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductSize
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 产品id
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Productsize { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 促销活动
        /// </summary>
        public string PromotionId { get; set; }
        /// <summary>
        /// 活动价格
        /// </summary>
        public double PromotionPrice { get; set; }
    }
}
