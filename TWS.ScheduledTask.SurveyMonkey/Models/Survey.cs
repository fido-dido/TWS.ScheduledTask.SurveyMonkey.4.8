namespace TWS.ScheduledTask.SurveyMonkey.Models
{
    public class Survey
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
        public string next { get; set; }
        public string last { get; set; }

    }

    public class Datum
    {
        public string id { get; set; }
        public string title { get; set; }
        public string nickname { get; set; }
        public string href { get; set; }
    }
}
