namespace TWS.ScheduledTask.SurveyMonkey.Models.CollectorRecipient
{

    public class CollectorRecipient
    {
        public Datum[] data { get; set; }
        public int per_page { get; set; }
        public int page { get; set; }
        public int total { get; set; }
        public Links links { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
    }

    public class Datum
    {
        public string id { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string href { get; set; }
    }

}
