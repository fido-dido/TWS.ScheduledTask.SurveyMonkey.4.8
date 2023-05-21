namespace Tws.SurveyMonkey.Data.Entities
{
    public class SMRecipient : IEntityId, ISMObjectId
    {
        public SMRecipient(int id, string recipientEntityId, int smCollectorId, string email, string phoneNumber)
        {
            Id= id;
            ObjectId = recipientEntityId;
            SMCollectorId = smCollectorId;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public SMRecipient(string recipientEntityId, int smCollectorId, string email, string phoneNumber) 
        {
            Id = default(int); 
            ObjectId = recipientEntityId;
            SMCollectorId = smCollectorId;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public int Id { get; set; }
        public string ObjectId { get; set; }
        public int SMCollectorId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
