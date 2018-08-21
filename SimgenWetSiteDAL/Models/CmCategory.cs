using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 栏目管理
    /// </summary>
    public class CmCategory
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string CateName { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string CateDesc { get; set; }
        /// <summary>
        /// Html标题
        /// </summary>
        public string HtmlTitle { get; set; }
        /// <summary>
        /// 试图模板
        /// </summary>
        public string ViewName { get; set; }
    }
}
