using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimgenWebSiteDAL.Models;

namespace SimgenWebSiteDAL.DAL
{
    public class QuestionDAL
    {
        private const string TableName = "qa_question";
        public bool Insert(Questions q)
        {
            q.Id = DBHelper<Questions>.GetMaxId(TableName, "id");
            return DBHelper<Questions>.Insert(TableName, DBHelper<Questions>.GetSim(q)) > 0;
        }

        public Questions GetQuestionById(int id)
        {
            string sql = string.Format("select * from qa_question where id = {0}", id);
            return DBHelper<Questions>.SelectSingle(sql);
        }

        public List<Questions> GetQuestionByProductId(int id)
        {
            string sql = string.Format("select * from qa_question where productId = {0}", id);
            return DBHelper<Questions>.Select(sql);
        }

        public List<Questions> GetQuestions(int pageSize, int pageIndex, out int Count)
        {
            return GetQuestions(pageSize, pageIndex, "", 0, out Count);
        }

        public List<Questions> GetQuestions(int pageSize, int pageIndex, string conStr, int productId, out int count)
        {
            string s = string.Empty;
            if (productId > 0)
                s = string.Format(" {1} = {0} ", productId, conStr);
            return DBHelper<Questions>.Select(pageSize, pageIndex, TableName, s, "id", false, out count, " id,title,memberId,productId,question,inTIme,ip,isDone,viewCount ");
        }

        public void SetAnswer(Questions q)
        {
            AnswerDAL answerDal = new AnswerDAL();
            Answers a = answerDal.GetLastAnswerByQuestionId(q.Id);
            if (a != null)
            {
                q.Count = answerDal.GetAnswerCountByQuestionId(q.Id);
                q.LastName = a.AnMemberName;
                q.LastTime = a.InTime;
            }
        }
    }
}
