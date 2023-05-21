using System;

namespace Tws.SurveyMonkey.Data.Entities
{

    public class SMResponse : IEntityId, ISMObjectId
    {
        public SMResponse(int id,string responseEntityId, string surveyEntityId, string collectorEntityId, string recipientEntityId, string pageEntityId, string questionEntityId, string choiceEntityId, string text, string ipAddress, string status)
        {
            Id = id;
            ObjectId = responseEntityId;
            SurveyEntityId = surveyEntityId;
            CollectorEntityId = collectorEntityId;
            RecipientEntityId = recipientEntityId;
            PageEntityId = pageEntityId;
            QuestionEntityId = questionEntityId;
            ChoiceEntityId = choiceEntityId;
            Text = text;
            IpAddress = ipAddress;
            Status = status;
        }

        public SMResponse(string responseEntityId, string surveyEntityId, string collectorEntityId, string recipientEntityId, string pageEntityId, string questionEntityId, string choiceEntityId, string text, string ipAddress, string status)
        {
            Id = default;
            ObjectId = responseEntityId;
            SurveyEntityId = surveyEntityId;
            CollectorEntityId = collectorEntityId;
            RecipientEntityId = recipientEntityId;
            PageEntityId = pageEntityId;
            QuestionEntityId = questionEntityId;
            ChoiceEntityId = choiceEntityId;
            Text = text;
            IpAddress = ipAddress;
            Status = status;
        }

        public int Id { get; set; }
        public string ObjectId { get; set; }

        public string SurveyEntityId { get; set; }
        public string CollectorEntityId { get; set; }
        public string RecipientEntityId { get; set; }
        public string PageEntityId { get; set; }
        public string QuestionEntityId { get; set; }
        public string ChoiceEntityId { get; set; }
        public string Text { get; set; }
        public string IpAddress { get; set; }
        public string Status{ get; set; }
    }
    public class SMResponseId : IEntityId, ISMObjectId
    {

        public SMResponseId(string objectId, long recipientId, string collectionMode, string responseStatus, string customValue, string firstName, string lastName, string emailAddress, string ipAddress)
        {
            ObjectId = objectId;
            RecipientId = recipientId;
            CollectionMode = collectionMode;
            ResponseStatus = responseStatus;
            CustomValue = customValue;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            IpAddress = ipAddress;
        }

        public int Id { get; set; }
        public string ObjectId { get; set; }

        public long RecipientId { get; set; }
        public string CollectionMode { get; set; }
        public string ResponseStatus { get; set; }
        public string CustomValue { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string IpAddress { get; set; }
    }
}
