namespace Tws.SurveyMonkey.Data.Entities
{
    public class SMQuestion : IEntityId, ISMObjectId
    {
        public SMQuestion(int id, string questionEntityId, int smPageId, string questionType, string question, int order)
        {
            Id = id;
            ObjectId = questionEntityId;
            SMPageId = smPageId;
            QuestionType = questionType;
            Question = question;
            Order = order;
        }

        public SMQuestion(string questionEntityId, int smPageId, string questionType, string question, int order)
        {

            Id = default(int);
            ObjectId = questionEntityId;
            SMPageId = smPageId;
            QuestionType = questionType;
            Question = question;
            Order = order;
        }

        public int Id { get; set; }
        public string ObjectId { get; set; }
        public int SMPageId { get; set; }
        public string QuestionType { get; set; }
        public string Question { get; set; }
        public int Order { get; set; }
    }
}
