namespace Tws.SurveyMonkey.Data.Entities
{
    public class SMCollector : IEntityId, ISMObjectId
    {
        public SMCollector(int id, string collectorEntityId, int smSurveyId, string name, string type, string email)
        {
            Id = id;
            ObjectId = collectorEntityId;
            SMSurveyId = smSurveyId;
            Name = name;
            Type = type;
            Email = email;
        }
        public SMCollector(string collectorEntityId, int smSurveyId, string name, string type, string email)
        {
            Id = default(int);
            ObjectId = collectorEntityId;
            SMSurveyId = smSurveyId;
            Name = name;
            Type = type;
            Email = email;
        }

        public int Id { get; set; }
        public string ObjectId { get; set; }
        public int SMSurveyId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
    }
}
