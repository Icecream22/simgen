using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class CommentInfoDAL
    {
        private const string tableName = "commentInfo";
        public CommentInfo GetCommentInfoById(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "id", Value = id };
            return DBHelper<CommentInfo>.SelectSingle(tableName, "*", s);
        }
        public List<CommentInfo> GetCommentInfoByContentId(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "contentId", Value = id };
            return DBHelper<CommentInfo>.Select(tableName, "*", s);
        }
    }
}
