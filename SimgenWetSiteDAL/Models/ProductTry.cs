using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 产品适用
    /// </summary>
    public class ProductTry
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 会员id
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// 产品id
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Mark { get; set; }
        /// <summary>
        /// 是否发出
        /// </summary>
        public int IsSend { get; set; }
        /// <summary>
        /// 系统说明
        /// </summary>
        public string SysReply { get; set; }
    }
}
