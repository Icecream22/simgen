using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class AnswerDAL
    {
        private const string tableName = "qa_answer";

        public bool Insert(Answers a)
        {
            a.Id = DBHelper<Answers>.GetMaxId(tableName, "id");
            return DBHelper<Answers>.Insert(tableName, DBHelper<Answers>.GetSim(a)) > 0;
        }
        public Answers GetAnswerById(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "id", Value = id };
            return DBHelper<Answers>.SelectSingle(tableName, "*", s);
        }

        public List<Answers> GetAnswerByQuestionId(int id, int pageSize, int pageNum, out int pageCount)
        {
            return DBHelper<Answers>.Select(pageSize, pageNum, tableName, " questionId = " + id, "id", false, out pageCount, " id,anMemberId,answer,inTime,ip,isSys ");
        }

        public Answers GetLastAnswerByQuestionId(int id)
        {
            List<SimpleParameter> list = new List<SimpleParameter>();
            SimpleParameter s = new SimpleParameter { Name = "questionId", Value = id };
            SimpleParameter s1 = new SimpleParameter { Sql = " order by inTime " };
            return DBHelper<Answers>.SelectSingle(tableName, "*", list);
        }

        public int GetAnswerCountByQuestionId(int id)
        {
            SimpleParameter s = new SimpleParameter { Name = "questionId", Value = id };
            return DBHelper<int>.SelectExecute(tableName, s);
        }
    }
}
