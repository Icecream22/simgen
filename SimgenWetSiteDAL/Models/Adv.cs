using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 广告
    /// </summary>
    public class Adv
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 广告名字
        /// </summary>
        public string AdName { get; set; }
        /// <summary>
        /// 图路径
        /// </summary>
        public string AdImgPath { get; set; }
        /// <summary>
        /// 图本地名
        /// </summary>
        public string AdImgLocal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AdImgMime { get; set; }
        /// <summary>
        /// 图size
        /// </summary>
        public string AdImgSize { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        public int AdPosition { get; set; }
        /// <summary>
        /// 跳转地址
        /// </summary>
        public string AdUrl { get; set; }
        /// <summary>
        /// 背景色
        /// </summary>
        public string BgColor { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int IsEnable { get; set; }

    }
}
