using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class WebMenuItemDAL
    {
        const string TABLE_NAME = "webMenu";
        const string FIELDS = "*";
        public List<WebMenuItem> GetAllMenu()
        {
           return  DBHelper<WebMenuItem>.Select(TABLE_NAME, FIELDS);
        }
    }
}
