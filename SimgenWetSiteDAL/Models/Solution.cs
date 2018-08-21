using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 解决方案
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string SolName { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string ImgPath { get; set; }
        /// <summary>
        /// 图片local
        /// </summary>
        public string ImgLocal { get; set; }
        /// <summary>
        /// 图片mime
        /// </summary>
        public string ImgMime { get; set; }
        /// <summary>
        /// 图片size
        /// </summary>
        public int ImgSize { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string SolDesc { get; set; }
        /// <summary>
        /// 浏览次数
        /// </summary>
        public int ViewCount { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int OrderNo { get; set; }
        /// <summary>
        /// 介绍
        /// </summary>
        public string SolIntro { get; set; }
    }
}