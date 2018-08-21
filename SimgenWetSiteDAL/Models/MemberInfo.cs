using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentData;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 用户
    /// </summary>
    public class MemberInfo
    {
        /// <summary>
        /// id
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string EnPassWord { get; set; }
        /// <summary>
        /// 是否激活邮箱
        /// </summary>
        public int IsActive { get; set; }
        /// <summary>
        /// 收集
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 第三方ID
        /// </summary>
        public string ThirdId { get; set; }
        /// <summary>
        /// 第三方
        /// </summary>
        public string ThirdParty { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string TrueName { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegTime { get; set; }
        /// <summary>
        /// 最近登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }
    }

}
