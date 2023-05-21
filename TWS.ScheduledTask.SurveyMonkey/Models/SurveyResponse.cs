using System;

namespace TWS.ScheduledTask.SurveyMonkey.Models.Response
{
    public class SurveResponse
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
        public string recipient_id { get; set; }
        public string collection_mode { get; set; }
        public string response_status { get; set; }
        public string custom_value { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email_address { get; set; }
        public string ip_address { get; set; }
        public Logic_Path logic_path { get; set; }
        public Metadata metadata { get; set; }
        public object[] page_path { get; set; }
        public string collector_id { get; set; }
        public string survey_id { get; set; }
        public Custom_Variables custom_variables { get; set; }
        public string edit_url { get; set; }
        public string analyze_url { get; set; }
        public int total_time { get; set; }
        public DateTime date_modified { get; set; }
        public DateTime date_created { get; set; }
        public string href { get; set; }
        public Page[] pages { get; set; }
    }

    public class Logic_Path
    {
    }

    public class Metadata
    {
        public Contact contact { get; set; }
    }

    public class Contact
    {
    }

    public class Custom_Variables
    {
    }

    public class Page
    {
        public string id { get; set; }
        public Question[] questions { get; set; }
    }

    public class Question
    {
        public string id { get; set; }
        public Answer[] answers { get; set; }
    }

    public class Answer
    {
        public string choice_id { get; set; }
        public string row_id { get; set; }
        public Choice_Metadata choice_metadata { get; set; }
        public object[] tag_data { get; set; }
        public string text { get; set; }
        public string col_id { get; set; }
    }

    public class Choice_Metadata
    {
        public string weight { get; set; }
    }

}
