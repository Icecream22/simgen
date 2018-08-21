using FluentData;
using System.Collections.Generic;
using SimgenWebSiteDAL.Help;
using System.Reflection;
using System;


namespace SimgenWebSiteDAL
{
    public class SimpleParameter
    {
        public string Name;
        public object Value;
        public string Sql;//自定义sql
    }

    public class DBHelper<T>
    {
        public static IDbContext Context()
        {
            return new DbContext().ConnectionStringName("DbConnectionStr",
                    DbProviderTypes.SqlServer);
        }

        public static List<SimpleParameter> GetSim(T t)
        {
            PropertyInfo[] props = null;
            try
            {
                Type type = typeof(T);
                object obj = Activator.CreateInstance(type);
                props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                List<SimpleParameter> list = new List<SimpleParameter>();
                foreach (PropertyInfo item in props)
                {
                    if (!item.IsSpecialName)
                    {
                        if (item.GetValue(t, null) != null)
                        {
                            SimpleParameter s = new SimpleParameter();
                            s.Name = item.Name;
                            s.Value = item.GetValue(t, null);
                            list.Add(s);
                        }
                    }
                }
                return list;
            }
            catch
            {
                return null;
            }
        }

        public static int GetMaxId(string tableName, string filed)
        {
            string sql = string.Format("select max({0}) from {1}", filed, tableName);
            try
            {
                IDbCommand command = Context().Sql(sql);
                int id = command.QueryValue<int>();
                id = id + 1;
                return id;
            }
            catch
            {
                return 1;
            }
        }

        #region insert
        /// <summary>
        /// 插入根据sql 语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Insert(string sql)
        {
            return Context().Sql(sql).ExecuteReturnLastId();
        }
        /// <summary>
        /// 插入一条数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="queryParme"></param>
        /// <returns></returns>
        public static int Insert(string tableName, List<SimpleParameter> queryParme)
        {
            string sqlStr = "insert into {0} ({1}) values ({2})";
            string queStr = string.Empty;
            string valStr = string.Empty;
            if (queryParme.Count > 0)
            {
                foreach (SimpleParameter item in queryParme)
                {
                    if (string.IsNullOrEmpty(queStr))
                        queStr = item.Name;
                    else
                        queStr += "," + item.Name;
                    if (string.IsNullOrEmpty(valStr))
                        valStr = "@" + item.Name;
                    else
                        valStr += "," + "@" + item.Name;
                }
                IDbCommand command = Context().Sql(string.Format(sqlStr, tableName, queStr, valStr));
                foreach (SimpleParameter item in queryParme)
                {
                    command.Parameter(item.Name, item.Value);
                }
                object obj = command.Execute();
                return Convert.ToInt32(obj);
            }
            else
            {
                return -1;
            }
        }
        #endregion

        #region update
        /// <summary>
        /// 更新sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            return Context().Sql(sql).Execute();
        }
        /// <summary>
        /// 更新单项
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="queryParme">queryParme.Name更新的列，queryParme.Value值，queryParme.Sql条件</param>
        /// <returns></returns>
        public static int Update(string tableName, SimpleParameter queryParme)
        {
            string sql = string.Format("update {0} set {1}={2} where {3}", tableName, queryParme.Name, queryParme.Value, queryParme.Sql);
            return Context().Sql(sql).Execute();
        }
        /// <summary>
        /// 更新多项
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="queryParme"></param>
        /// <param name="whereStr"></param>
        /// <returns></returns>
        public static int Update(string tableName, List<SimpleParameter> queryParme, string whereStr)
        {
            if (queryParme.Count > 0)
            {
                string sqlStr = "update {0} set {1} where {2}";
                string valStr = string.Empty;
                foreach (SimpleParameter item in queryParme)
                {
                    if (string.IsNullOrEmpty(valStr))
                        valStr = string.Format("{0} = @{0}", item.Name);
                    else
                        valStr += "," + string.Format("{0} = @{0}", item.Name);
                }
                IDbCommand command = Context().Sql(string.Format(sqlStr, tableName, valStr, whereStr));
                foreach (SimpleParameter item in queryParme)
                {
                    command.Parameter(item.Name, item.Value);
                }
                return command.Execute();
            }
            else
            {
                return -1;
            }
        }
        #endregion

        #region select
        public static List<T> Select(string sql)
        {
            List<T> result;
            IDbCommand command = Context().Sql(sql);
            result = command.Query<T>();
            return result;
        }
        /// <summary>
        /// count(*)语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int SelectExecute(string sql)
        {
            IDbCommand command = Context().Sql(sql);
            return command.QueryValue<int>();
        }
        /// <summary>
        /// count(*)语句
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="queryParams"></param>
        /// <param name="fileds">count(*)或者指定int列</param>
        /// <returns></returns>
        public static int SelectExecute(string tableName, string fileds, SimpleParameter queryParams)
        {
            string whereStr = "";
            if (queryParams != null)
            {
                if (!string.IsNullOrEmpty(queryParams.Sql))
                {
                    whereStr = string.Format(" where {0}=@{0} ", queryParams.Name);
                }
                else
                {
                    whereStr = queryParams.Sql;
                }
            }
            string sql = string.Format("select {2} from {1} {0}", whereStr, tableName, fileds);
            IDbCommand command = Context().Sql(sql);
            if (queryParams != null && !string.IsNullOrEmpty(queryParams.Sql))
            {
                command.Parameters(queryParams.Name, queryParams.Value);
            }
            return command.QueryValue<int>();
        }
        public static int SelectExecute(string tableName, SimpleParameter queryParams)
        {
            return SelectExecute(tableName, "count(*)", queryParams);
        }

        public static List<T> Select(string tableName, string fields, SimpleParameter queryParams, int topNum = -1)
        {
            List<T> result;
            string whereStr = " where 1=1 ";
            if (queryParams != null)
            {
                if (!string.IsNullOrEmpty(queryParams.Sql))
                {
                    whereStr += queryParams.Sql;
                }
                else
                {
                    whereStr += string.Format(" and {0}=@{1}", queryParams.Name, queryParams.Name);
                }
            }
            string topStr = " top {0}";
            if (topNum <= 0)
            {
                topStr = "";
            }
            else
            {
                topStr = string.Format(topStr, topNum);
            }

            string sql = string.Format("select {2} {0} from {1} {3}", fields, tableName, topStr, whereStr);
            IDbCommand command = Context().Sql(sql);
            if (queryParams != null)
            {
                if (string.IsNullOrEmpty(queryParams.Sql))
                {
                    command.Parameter(queryParams.Name, queryParams.Value);
                }
            }
            result = command.Query<T>();
            return result;
        }
        /// <summary>
        /// 分页数据查询
        /// </summary>
        /// <param name="pageSize">一个多少个</param>
        /// <param name="pageNum">当前第几页</param>
        /// <param name="tableName">表名</param>
        /// <param name="whereSql">条件</param>
        /// <param name="orderStr">排序列名</param>
        /// <param name="shunxu">正排？</param>
        /// <param name="pageCount">总数</param>
        /// <param name="fileds">要查询的字段</param>
        /// <returns></returns>
        public static List<T> Select(int pageSize, int pageNum, string tableName, string whereSql, string orderStr, bool shunxu, out int pageCount, string fileds)
        {
            pageCount = SelectExecute(string.Format("select count(*) from {0} where 1=1 {1}", tableName, string.IsNullOrEmpty(whereSql) ? "" : " and " + whereSql));
            string sql = string.Format("with pageTable as (select row_number() over(order by {1} {3}) rowNumber,{6} from {0} where 1=1 {2})select {6} from pageTable where rowNumber between {4} and {5}", tableName, orderStr, string.IsNullOrEmpty(whereSql) ? "" : " and " + whereSql, shunxu ? " ASC " : " DESC ", pageSize * (pageNum - 1) + 1, pageSize * pageNum, string.IsNullOrEmpty(fileds) ? " * " : fileds);
            return Select(sql);
        }
        public static List<T> Select(string tableName, string fields, List<SimpleParameter> queryParams = null, int topNum = -1)
        {
            List<T> result;
            string whereStr = " where 1=1 ";
            if (queryParams != null && queryParams.Count > 0)
            {
                foreach (var item in queryParams)
                {
                    if (!string.IsNullOrEmpty(item.Sql))
                    {
                        whereStr += item.Sql;
                    }
                    else
                    {
                        whereStr += string.Format(" and {0}=@{1}", item.Name, item.Name);
                    }
                }
            }
            string topStr = " top {0}";
            if (topNum <= 0)
            {
                topStr = "";
            }
            else
            {
                topStr = string.Format(topStr, topNum);
            }

            string sql = string.Format("select {2} {0} from {1} {3}", fields, tableName, topStr, whereStr);
            IDbCommand command = Context().Sql(sql);
            if (queryParams != null && queryParams.Count > 0)
            {
                foreach (var item in queryParams)
                {
                    if (string.IsNullOrEmpty(item.Sql))
                    {
                        command.Parameter(item.Name, item.Value);
                    }
                }
            }
            result = command.Query<T>();
            return result;
        }

        public static T SelectSingle(string tableName, string fields, List<SimpleParameter> queryParams)
        {

            List<T> result = Select(tableName, fields, queryParams, 1);
            if (result != null && result.Count > 0)
            {
                return result[0];
            }
            return default(T);
        }
        public static T SelectSingle(string tableName, string fields, SimpleParameter queryParams)
        {
            List<SimpleParameter> list = new List<SimpleParameter>();
            list.Add(queryParams);
            List<T> result = Select(tableName, fields, list, 1);
            if (result != null && result.Count > 0)
            {
                return result[0];
            }
            return default(T);
        }
        public static T SelectSingle(string sql)
        {
            List<T> result = Select(sql);
            if (result != null && result.Count > 0)
            {
                return result[0];
            }
            return default(T);
        }
        #endregion

        public static T SelectField(string tableName, string fields, List<SimpleParameter> queryParams = null, int topNum = -1)
        {
            string whereStr = " where 1=1 ";
            if (queryParams != null && queryParams.Count > 0)
            {
                foreach (var item in queryParams)
                {
                    if (!string.IsNullOrEmpty(item.Sql))
                    {
                        whereStr += item.Sql;
                    }
                    else
                    {
                        whereStr += string.Format(" and {0}=@{1}", item.Name, item.Name);
                    }
                }
            }
            string topStr = " top {0}";
            if (topNum <= 0)
            {
                topStr = "";
            }
            else
            {
                topStr = string.Format(topStr, topNum);
            }

            string sql = string.Format("select {2} {0} from {1} {3}", fields, tableName, topStr, whereStr);
            IDbCommand command = Context().Sql(sql);
            if (queryParams != null && queryParams.Count > 0)
            {
                foreach (var item in queryParams)
                {
                    if (string.IsNullOrEmpty(item.Sql))
                    {
                        command.Parameter(item.Name, item.Value);
                    }
                }
            }
            return command.QueryValue<T>();
        }
        public static T SelectField(string tableName, string fields, SimpleParameter queryParams = null, int topNum = -1)
        {
            string whereStr = " where 1=1 ";
            if (queryParams != null)
            {
                if (!string.IsNullOrEmpty(queryParams.Sql))
                {
                    whereStr += queryParams.Sql;
                }
                else
                {
                    whereStr += string.Format(" and {0}=@{1}", queryParams.Name, queryParams.Name);
                }
            }
            string topStr = " top {0}";
            if (topNum <= 0)
            {
                topStr = "";
            }
            else
            {
                topStr = string.Format(topStr, topNum);
            }

            string sql = string.Format("select {2} {0} from {1} {3}", fields, tableName, topStr, whereStr);
            IDbCommand command = Context().Sql(sql);
            if (queryParams != null)
            {
                if (string.IsNullOrEmpty(queryParams.Sql))
                {
                    command.Parameter(queryParams.Name, queryParams.Value);
                }
            }
            return command.QueryValue<T>();
        }
    }
}
