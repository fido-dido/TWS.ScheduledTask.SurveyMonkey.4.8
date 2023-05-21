namespace TWS.ScheduledTask.SurveyMonkey.Models.Collector
{
    public class SurveyCollector
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
        public string name { get; set; }
        public string id { get; set; }
        public string href { get; set; }
        public string type { get; set; }
        public string email { get; set; }
        public bool is_sender_email_verified { get; set; }
    }
}
