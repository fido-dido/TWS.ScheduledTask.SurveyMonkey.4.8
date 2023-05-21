namespace Tws.SurveyMonkey.Data.Entities
{
    public class SMChoice : IEntityId, ISMObjectId
    {
        public SMChoice(int id, string choiceEntityId, int smQuestionId, string name, int order)
        {
            Id = id;
            ObjectId = choiceEntityId;
            SMQuestionId = smQuestionId;
            Name = name;
            Order = order;
        }

        public SMChoice(string choiceEntityId, int smQuestionId, string name, int order)
        {
            Id = default(int);
            ObjectId = choiceEntityId;
            SMQuestionId = smQuestionId;
            Name = name;
            Order = order;
        }

        public int Id { get; set; }
        public string ObjectId { get; set; }
        public int SMQuestionId { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        //public override bool Equals(object? obj)
        //{
        //    if (obj is not SMChoice) return false;
        //    if (obj == null) return false;
        //    return ((SMChoice)obj).ObjectId == ObjectId;
        //}
        //public override int GetHashCode()
        //{
        //    return int.Parse(ObjectId);
        //}
    }
}
