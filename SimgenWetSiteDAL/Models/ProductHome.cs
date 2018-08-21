using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductHome
    {
        /// <summary>
        /// 
        /// </summary>
        public List<PmCategory> PmCategorys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<PmCategory> PmSonCategorys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Product> InnovatoryProducts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Solution> Solutions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Adv> Advs { get; set; }
    }
}
