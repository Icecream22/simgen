using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;
using SimgenWebSiteDAL.Help;

namespace SimgenWebSiteDAL.DAL
{
    public class MemberDAL
    {
        private const string tableName = "mi_member";
        public bool Insert(MemberInfo m)
        {
            m.Id = null;//DBHelper<MemberInfo>.GetMaxId(tableName, "id");
            return DBHelper<MemberInfo>.Insert(tableName, DBHelper<MemberInfo>.GetSim(m)) > 0;
        }

        public bool Update(string field, string val, string requirement)
        {
            SimpleParameter s = new SimpleParameter()
            {
                Name = field,
                Value = val,
                Sql = requirement
            };
            return DBHelper<MemberInfo>.Update(tableName, s) > 0;
        }

        public bool Update(MemberInfo m)
        {
            List<SimpleParameter> list = new List<SimpleParameter>();
            GetListSim(list, m);
            return DBHelper<MemberInfo>.Update(tableName, list, "id=" + m.Id) > 0;
        }

        public MemberInfo GetMemberById(string id)
        {
            SimpleParameter s = new SimpleParameter() { Name = "id", Value = id };
            return DBHelper<MemberInfo>.SelectSingle(tableName, "*", s);
        }

        public MemberInfo CheckMember(string email, string pass)
        {
            SimpleParameter s = new SimpleParameter() { Name = "email", Value = email };
            SimpleParameter s1 = new SimpleParameter() { Name = "enpassword", Value = pass };
            List<SimpleParameter> list = new List<SimpleParameter>();
            list.Add(s);
            list.Add(s1);
            return DBHelper<MemberInfo>.SelectSingle(tableName, "*", list);
        }

        public MemberInfo GetMemberByName(string name)
        {
            SimpleParameter s = new SimpleParameter() { Name = "nickName", Value = name };
            return DBHelper<MemberInfo>.SelectSingle(tableName, "*", s);
        }

        public string GetMemberNameById(int id)
        {
            return DBHelper<string>.SelectField(tableName, "nickName", new SimpleParameter { Name = "id", Value = id });
        }

        public string GetMemberField(string field, string val)
        {
            return DBHelper<string>.SelectField(tableName, field, new SimpleParameter { Name = field, Value = val });
        }


        public void GetListSim(List<SimpleParameter> list, MemberInfo m)
        {
            if (ToolHelp.ToInt(m.Id) > 0)
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "id";
                s.Value = m.Id;
                list.Add(s);
            }
            if (!string.IsNullOrEmpty(m.Company))
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "Company";
                s.Value = m.Company;
                list.Add(s);
            }
            if (!string.IsNullOrEmpty(m.Email))
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "Email";
                s.Value = m.Email;
                list.Add(s);
            }
            if (!string.IsNullOrEmpty(m.EnPassWord))
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "EnPassWord";
                s.Value = m.EnPassWord;
                list.Add(s);
            }
            if (ToolHelp.ToInt(m.IsActive) >= 0)
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "IsActive";
                s.Value = m.IsActive;
                list.Add(s);
            }
            if (ToolHelp.ToDateTime(m.LastLoginTime) != null)
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "LastLoginTime";
                s.Value = m.LastLoginTime;
                list.Add(s);
            }
            if (!string.IsNullOrEmpty(m.Mobile))
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "Mobile";
                s.Value = m.Mobile;
                list.Add(s);
            }
            if (!string.IsNullOrEmpty(m.NickName))
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "NickName";
                s.Value = m.NickName;
                list.Add(s);
            }
            if (ToolHelp.ToDateTime(m.RegTime) != null)
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "RegTime";
                s.Value = m.RegTime;
                list.Add(s);
            }
            if (!string.IsNullOrEmpty(m.Tel))
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "Tel";
                s.Value = m.Tel;
                list.Add(s);
            }
            if (!string.IsNullOrEmpty(m.ThirdId))
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "ThirdId";
                s.Value = m.ThirdId;
                list.Add(s);
            }
            if (!string.IsNullOrEmpty(m.ThirdParty))
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "ThirdParty";
                s.Value = m.ThirdParty;
                list.Add(s);
            }
            if (!string.IsNullOrEmpty(m.TrueName))
            {
                SimpleParameter s = new SimpleParameter();
                s.Name = "TrueName";
                s.Value = m.TrueName;
                list.Add(s);
            }
        }
    }
}
