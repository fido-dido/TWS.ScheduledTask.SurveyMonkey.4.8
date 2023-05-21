
namespace TWS.ScheduledTask.SurveyMonkey.Models
{

    public class ApiError
    {
        public Error error { get; set; }
    }

    public class Error
    {
        public string docs { get; set; }
        public string message { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public int http_status_code { get; set; }
    }

}
