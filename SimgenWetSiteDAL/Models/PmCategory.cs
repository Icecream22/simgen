using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 产品类目
    /// </summary>
    public class PmCategory
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
        public string CateName{get;set;}
        /// <summary>
        /// 父类id
        /// </summary>
        public int ParentId{get;set;}
        /// <summary>
        /// 描述
        /// </summary>
        public string Description{get;set;}
        /// <summary>
        /// 排序
        /// </summary>
        public int OrderNo { get; set; }
    }
}
