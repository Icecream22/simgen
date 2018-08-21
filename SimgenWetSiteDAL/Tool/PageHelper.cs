using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SimgenWebSiteDAL.Help
{
    /// <summary>
    /// 分页的类
    /// </summary>
    public class PageHelper
    {
        private int fPerPageSize = 20;
        private bool fIsNeedPage = true;
        public PageHelper(int perPageSize, int totalRecords)
        {
            fPerPageSize = perPageSize;
            PageSize = fPerPageSize;
            if (totalRecords == 0)
            {
                IsNeedPage = false;
                return;
            }
            if (totalRecords <= perPageSize)
            {
                TotalPage = 1;
                IsNeedPage = false;
            }
            else
            {
                if ((totalRecords % perPageSize) > 0)
                    TotalPage = totalRecords / perPageSize + 1;
                else
                    TotalPage = totalRecords / perPageSize;
            }

        }

        public int PageSize { get; set; }
        public int TotalPage { get; set; }
        public int CurrentPage { get; set; }
        public string PageHref { get; set; }
        public string HrefSuffix { get; set; }
        private bool fIsNofollow = false;
        public bool IsNofollow
        {
            get
            {
                return fIsNofollow;
            }
            set
            {
                fIsNofollow = value;
            }
        }
        public bool IsNeedPage
        {
            get
            {
                return fIsNeedPage;
            }
            private set
            {
                fIsNeedPage = value;
            }
        }

        public string GetPageHtml()
        {
            if (!IsNeedPage)
                return "";
            return PageUrl(TotalPage, CurrentPage, PageHref, HrefSuffix);
        }

        #region 分页
        private string PageUrl(int totalPage, int currentPage, string pageHref, string hrefSuffix)
        {
            int displayPadgeSize = 6;
            int up = 1;
            int down = 6;
            string curClass = " class=\"page_num\"";
            string rel = "";
            string pageText = "";
            if (currentPage >= displayPadgeSize - 1)
            {
                up = currentPage - 3;
                down = currentPage + 2;
            }
            if (totalPage < down)
            {
                up = (totalPage > 5) ? totalPage - 5 : 1;
                down = totalPage;
            }
            if (up != 1)
            {
                pageText += string.Format("<a class=\"page_num page_character\" href=\"{1}1{2}\" >首页</a><a  class=\"page_num page_character\" href=\"{1}{0}{2}\">上一页</a>",
    (currentPage - 1), pageHref, hrefSuffix);
            }

            for (int i = up; i <= down; i++)
            {
                curClass = " class=\"page_num\"";
                rel = "";
                if (currentPage - 1 == i)
                {
                    rel = "rel=\"prev\"";
                }
                if (currentPage + 1 == i)
                {
                    rel = "rel=\"next\"";
                }
                if (currentPage == i)
                {
                    curClass = " class=\"page_num page_num_cur\"";//当前页class

                }
                if (IsNofollow)
                    rel = "rel=\"nofollow\"";
                pageText += string.Format("<a " + curClass + " href=\"{1}{0}{2}\" {3}>{0}</a>",
                    i, pageHref, hrefSuffix, rel);
            }
            if (down != totalPage)
            {
                rel = "";
                if (IsNofollow)
                    rel = "rel=\"nofollow\"";
                pageText += string.Format("<a class=\"page_num page_character\" href=\"{2}{0}{3}\">下一页</a><a class=\"page_num page_character\" href=\"{2}{1}{3}\" {4}>尾页</a>",
(currentPage + 1), totalPage, pageHref, hrefSuffix, rel);

            }
            return pageText;
        }
        #endregion
    }
}
