using System.Configuration;

namespace TWS.ScheduledTask.SurveyMonkey.Config
{
    public class SurveyMonkeyApiEndpoints
    {
        public SurveyMonkeyApiEndpoints()
        {

            Surveys = ConfigurationManager.AppSettings["SurveyMonkeyApiEndpoints_Surveys"];
            SurveysPerPageParam = ConfigurationManager.AppSettings["SurveyMonkeyApiEndpoints_SurveysPerPageParam"];
            SurveyStartModifiedAt = ConfigurationManager.AppSettings["SurveyMonkeyApiEndpoints_SurveyStartModifiedAt"];
            SurveyEndModifiedAt = ConfigurationManager.AppSettings["SurveyMonkeyApiEndpoints_SurveyEndModifiedAt"];
            SurveyNumberOfDaysToLoad  = ConfigurationManager.AppSettings["SurveyMonkeyApiEndpoints_SurveyNumberOfDaysToLoad"];

            SurveysById  = ConfigurationManager.AppSettings["SurveyMonkeyApiEndpoints_SurveysById"];
            SurveyDetails = ConfigurationManager.AppSettings["SurveyMonkeyApiEndpoints_SurveyDetails"];
            SurveyCollectors = ConfigurationManager.AppSettings["SurveyMonkeyApiEndpoints_SurveyCollectors"];
            CollectorRecipients = ConfigurationManager.AppSettings["SurveyMonkeyApiEndpoints_CollectorRecipients"];
            SurveyReponse = ConfigurationManager.AppSettings["SurveyMonkeyApiEndpoints_SurveyReponse"];

        }
        public string Surveys { get; set; }
        public string SurveysById { get; set; }
        public string SurveyDetails { get; set; }
        public string SurveyPages { get; set; }
        public string SurveyByPageId { get; set; }
        public string SurveyQuestionsInPageId { get; set; }
        public string SurveyQuestionInPage { get; set; }
        public string SurveyReponse { get; set; }
        public string SurveysPerPageParam {get; set; }
        public string SurveyStartModifiedAt { get; set; }
        public string SurveyEndModifiedAt { get; set; }
        public string SurveyNumberOfDaysToLoad { get; set; }
        public string SurveyCollectors { get; set; }
        public string CollectorRecipients { get; set; } 
    }
}
