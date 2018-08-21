using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimgenWebSiteDAL.Models
{
    public class ProductCategory
    {
        public string Id { get; set; }
        public string CateName { get; set; }
        public string ParentId { get; set; }
        public string Description { get; set; }
    }
}
