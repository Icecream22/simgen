using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 全局配置
    /// </summary>
    public class SysConfig
    {
        /// <summary>
        /// id
        /// </summary>
        public int V_Id { get; set; }
        /// <summary>
        /// 变量名
        /// </summary>
        public string V_Name { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public string V_Value { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string V_Desc { get; set; }
    }
}
