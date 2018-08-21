using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class SysConfigDAL
    {
        private const string tableName = "sys_config";
        public SysConfig GetConfigById(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "v_id", Value = id };
            return DBHelper<SysConfig>.SelectSingle(tableName, "*", s);
        }
    }
}
