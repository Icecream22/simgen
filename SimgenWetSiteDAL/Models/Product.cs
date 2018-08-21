using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 产品
    /// </summary>
    public class Product
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProName { get; set; }
        /// <summary>
        /// 是否是创新产品
        /// </summary>
        public int IsNew { get; set; }
        /// <summary>
        /// 创新描述
        /// </summary>
        public string NewDesc { get; set; }
        /// <summary>
        /// 是否是热门产品
        /// </summary>
        public int IsHot { get; set; }
        /// <summary>
        /// html标题
        /// </summary>
        public string HTMLTitle { get; set; }
        /// <summary>
        /// 浏览次数
        /// </summary>
        public string ViewCount { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// 说明书
        /// </summary>
        public string Doc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DocLocal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DocMime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int DocSize { get; set; }
        /// <summary>
        /// 目录编号
        /// </summary>
        public string ProNo { get; set; }
        /// <summary>
        /// 适用标本
        /// </summary>
        public string ProSpecimen { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string ProDesc { get; set; }
        /// <summary>
        /// 相关产品
        /// </summary>
        public string RelProduct { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int OrderNo { get; set; }
        /// <summary>
        /// 类别id
        /// </summary>
        public string Categoryid{get;set;}
        /// <summary>
        /// 类别名称
        /// </summary>
        public string CateName { get; set; }

        /// <summary>
        /// 视频地址
        /// </summary>
        public string VideoUrl { get; set; }

    }
}
