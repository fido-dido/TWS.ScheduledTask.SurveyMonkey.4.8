namespace Tws.SurveyMonkey.Data.Entities
{
    public class SMPage : IEntityId, ISMObjectId
    {
        public SMPage(int id, string pageEntityId, int smSurveyId, string title, string description, int questionCount, int order)
        {
            Id = id;
            ObjectId = pageEntityId;
            SMSurveyId = smSurveyId;
            Title = title;
            Description = description;
            QuestionCount = questionCount;
            Order = order;
        }
        public SMPage(string pageEntityId, int smSurveyId, string title, string description, int questionCount,int order)
        {
            Id = default(int);
            ObjectId = pageEntityId;
            SMSurveyId = smSurveyId;
            Title = title;
            Description = description;
            QuestionCount = questionCount;
            Order = order;
        }

        public int Id { get; set; }
        public string ObjectId { get; set; }
        public int SMSurveyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int QuestionCount { get; set; }
        public int Order { get; set; }
    }
}
