using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 问题
    /// </summary>
    public class Questions
    {
        /// <summary>
        /// 不需要的字段
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 会员
        /// </summary>
        public string MemberId { get; set; }
        /// <summary>
        /// 用户ip
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 对应产品
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Question { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 是否解决
        /// </summary>
        public int IsDone { get; set; }
        /// <summary>
        /// 浏览次数
        /// </summary>
        public int ViewCount { get; set; }
        /// <summary>
        /// 回复/评论次数
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 最后回复人
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 最后回复时间
        /// </summary>
        public DateTime LastTime { get; set; }
    }
}
