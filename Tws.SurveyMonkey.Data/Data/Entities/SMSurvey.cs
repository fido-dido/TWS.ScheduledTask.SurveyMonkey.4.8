using Dapper;
using System.Data;
using NLog;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Tws.SurveyMonkey.Data.Entities
{
    public class SMSurvey : IEntityId, ISMObjectId
    {
        public SMSurvey(int id, string surveyEntityId, string title, string category, int questionCount, int pageCount, int responseCount, DateTime createdDate, DateTime modifiedDate)
        {
            Id = id;
            ObjectId = surveyEntityId;
            Title = title;
            Category = category;
            QuestionCount = questionCount;
            PageCount = pageCount;
            ResponseCount = responseCount;
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
        }

        public SMSurvey(string surveyEntityId, string title, string category, int questionCount, int pageCount, int responseCount, DateTime createdDate, DateTime modifiedDate)
        {
            Id = default;
            ObjectId = surveyEntityId;
            Title = title;
            Category = category;
            QuestionCount = questionCount;
            PageCount = pageCount;
            ResponseCount = responseCount;
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
        }

        public int Id { get; set; }  
        public string ObjectId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int QuestionCount { get; set; }
        public int PageCount { get; set; }
        public int ResponseCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
