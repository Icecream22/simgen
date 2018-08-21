using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class AgentInfoDAL
    {
        private const string tableName = "agent_info";
        public AgentInfo GetAgentById(int id)
        {
            return DBHelper<AgentInfo>.SelectSingle(tableName, "*", new SimpleParameter { Name = "id", Value = id });
        }

        public List<AgentInfo> GetAgent()
        {
            return DBHelper<AgentInfo>.Select(tableName, "*");
        }
    }
}
