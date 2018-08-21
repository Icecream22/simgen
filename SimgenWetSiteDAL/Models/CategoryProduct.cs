using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 产品类别
    /// </summary>
    public class CategoryProduct
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 类别id
        /// </summary>
        public string CateId { get; set; }
        /// <summary>
        /// 产品id
        /// </summary>
        public string ProductId { get; set; }
        
    }
}
