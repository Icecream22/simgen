using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class WebMenuItem
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }
        /// <summary>
        /// 父菜单
        /// </summary>
        public string ParentMenuId { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string MenuHref { get; set; }
        /// <summary>
        /// 目标【新窗口】
        /// </summary>
        public string HrefTarget { get; set; }
        /// <summary>
        /// 显示title
        /// </summary>
        public string Title { get; set; }
    }
}