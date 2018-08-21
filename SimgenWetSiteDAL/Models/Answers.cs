using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 回答
    /// </summary>
    public class Answers
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 问题id
        /// </summary>
        public int QuestionId { get; set; }
        /// <summary>
        /// 回答会员
        /// </summary>
        public int AnMemberId { get; set; }
        /// <summary>
        /// 回答内容
        /// </summary>
        public string Answer { get; set; }
        /// <summary>
        /// 回答时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 回答ip
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 是否是系统回答
        /// </summary>
        public int IsSys { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string AnMemberName { get; set; }
    }
}
