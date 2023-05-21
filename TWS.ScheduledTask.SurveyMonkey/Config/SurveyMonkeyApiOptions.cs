using System.Configuration;

namespace TWS.ScheduledTask.SurveyMonkey.Config
{
    public sealed class SurveyMonkeyApiOptions
    {
        public SurveyMonkeyApiOptions() {
            BaseAddress = ConfigurationManager.AppSettings["SurveyMonkeyApiOptions_BaseAddress"];
            TimeOutInSeconds = int.Parse(ConfigurationManager.AppSettings["SurveyMonkeyApiOptions_TimeOutInSeconds"]);
            ApiVersion = ConfigurationManager.AppSettings["SurveyMonkeyApiOptions_ApiVersion"];
            AccessToken = ConfigurationManager.AppSettings["SurveyMonkeyApiOptions_AccessToken"];
        }
        public static string SectionName = "SurveyMonkeyApiOptions";
        public string BaseAddress { get; set; }
        public string ClientId { get; set; }
        public string Secret { get; set; }
        public string AccessToken { get; set; }
        public int TimeOutInSeconds { get; set; }
        public string ApiVersion { get; set; }
    }
}
