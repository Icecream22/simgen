using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 广告
    /// </summary>
    public class AdSlider
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
        ///
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TitleColor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsSHow { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AdText1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AdText2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AdText3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Btn1Text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Btn1ToUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Btn2Text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Btn2ToUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string AddTime { get; set; }
        public string OrderNo { get; set; }
        public string BgImg { get; set; }


    }
}
