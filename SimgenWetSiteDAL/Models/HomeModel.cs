using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    public class HomeModel
    {
        public HomeModel()
        {
        }

        public List<Adv> Advs { get; set; }

        /// <summary>
        /// 四栏标题和更多设置
        /// </summary>
        public List<HomePageSetting> HomePageSettings { get; set; }

        /// <summary>
        /// 四栏配置下的数据
        /// </summary>
        public List<HomePageSetting> HomePageSettingsDetail { get; set; }
        
    }
}
