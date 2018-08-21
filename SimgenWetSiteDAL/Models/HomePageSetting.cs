using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 首页四列
    /// </summary>
    public class HomePageSetting
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int OrderNo { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string DispName { get; set; }
        /// <summary>
        /// 更多名称
        /// </summary>
        public string MoreName { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 是否主题
        /// </summary>
        public int IsMain { get; set; }
        /// <summary>
        /// 是否换行提示
        /// </summary>
        public int IsNewRow { get; set; }
        /// <summary>
        /// 主题id
        /// </summary>
        public int MainId { set; get; }
    }
}
