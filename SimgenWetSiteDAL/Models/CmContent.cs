using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 内容管理
    /// </summary>
    public class CmContent
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public string tags { get; set; }
        /// <summary>
        /// 所属栏目
        /// </summary>
        public int CateId { get; set; }
        /// <summary>
        /// HTML标题
        /// </summary>
        public string HtmlTitle { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 浏览次数
        /// </summary>
        public int ViewCount { get; set; }
        /// <summary>
        /// 是否开放评论
        /// </summary>
        public int IsComment { get; set; }
    }
}
