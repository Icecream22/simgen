using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 评论
    /// </summary>
    public class CommentInfo
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 内容id
        /// </summary>
        public int comtentId { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string commentContent { get; set; }
        /// <summary>
        /// 会员id
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 评论ip
        /// </summary>
        public string InIP { get; set; }
    }
}
