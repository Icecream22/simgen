using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Text.RegularExpressions;

namespace SimgenWebSiteDAL.Help
{
    public static class ToolHelp
    {
        #region 转换
        /// <summary>
        /// 转换为string格式
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToString(object obj)
        {
            try
            {
                return Convert.ToString(obj);
            }
            catch
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// 转换为int格式
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToInt(object obj)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// 转换为float格式
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static float ToFloat(object obj)
        {
            try
            {
                return Convert.ToSingle(obj);
            }
            catch
            {
                return 0.0f;
            }
        }
        /// <summary>
        /// 转换为double格式
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double ToDouble(object obj)
        {
            try
            {
                return Convert.ToDouble(obj);
            }
            catch
            {
                return 0.0;
            }
        }
        /// <summary>
        /// 时间格式转为短字符串（yyyy-MM-dd）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToShotDateString(DateTime obj)
        {
            try
            {
                return obj.ToString("yyyy-MM-dd");
            }
            catch
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// 转换时间格式
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(object obj)
        {
            try
            {
                return Convert.ToDateTime(obj);
            }
            catch
            {
                throw new Exception("转换为时间格式失败");
            }
        }

        #endregion

        #region Help
        /// <summary>
        /// 得到当前请求的域名的url地址
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetUrl(HttpRequestBase request)
        {
            if (request.Url.IsDefaultPort)
                return string.Format("http://{0}/", request.Url.Host);
            return string.Format("http://{0}:{1}/", request.Url.Host, request.Url.Port);
        }

        /// <summary>
        /// 得到当前请求的ip
        /// </summary>
        /// <returns></returns>
        public static string GetIP()
        {
            string result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (null == result || result == String.Empty)
            {
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }

            if (null == result || result == String.Empty)
            {
                result = HttpContext.Current.Request.UserHostAddress;
            }
            return result;
        }
        #endregion

        #region other
        /// <summary>
        /// 判断是否符合正则表达式
        /// </summary>
        /// <param name="str">要判断的字符串</param>
        /// <param name="reg">正则的表达式</param>
        /// <returns></returns>
        public static bool Check(string str,string reg)
        {
            Regex r = new Regex(reg);
            return r.IsMatch(str);
        }

        #endregion
    }
}
