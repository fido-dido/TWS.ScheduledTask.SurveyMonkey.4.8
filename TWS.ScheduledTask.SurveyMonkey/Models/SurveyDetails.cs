using System;

namespace TWS.ScheduledTask.SurveyMonkey.Models
{
    public class SurveyDetails
    {
        public string title { get; set; }
        public string nickname { get; set; }
        public string language { get; set; }
        public string folder_id { get; set; }
        public string category { get; set; }
        public int question_count { get; set; }
        public int page_count { get; set; }
        public int response_count { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_modified { get; set; }
        public string id { get; set; }
        public Buttons_Text buttons_text { get; set; }
        public bool is_owner { get; set; }
        public bool footer { get; set; }
        public string theme_id { get; set; }
        public Custom_Variables custom_variables { get; set; }
        public string href { get; set; }
        public string analyze_url { get; set; }
        public string edit_url { get; set; }
        public string collect_url { get; set; }
        public string summary_url { get; set; }
        public string preview { get; set; }
        public Page[] pages { get; set; }
    }

    public class Buttons_Text
    {
        public string next_button { get; set; }
        public string prev_button { get; set; }
        public string done_button { get; set; }
        public string exit_button { get; set; }
    }

    public class Custom_Variables
    {
    }

    public class Page
    {
        public string title { get; set; }
        public string description { get; set; }
        public int position { get; set; }
        public int question_count { get; set; }
        public string id { get; set; }
        public string href { get; set; }
        public Question[] questions { get; set; }
    }

    public class Question
    {
        public string id { get; set; }
        public int position { get; set; }
        public bool visible { get; set; }
        public string family { get; set; }
        public string subtype { get; set; }
        public object layout { get; set; }
        public object sorting { get; set; }
        public object required { get; set; }
        public Validation validation { get; set; }
        public bool forced_ranking { get; set; }
        public Heading[] headings { get; set; }
        public string href { get; set; }
        public Answers answers { get; set; }
        public Display_Options display_options { get; set; }
    }

    public class Validation
    {
        public string type { get; set; }
        public string text { get; set; }
        public string max { get; set; }
        public string min { get; set; }
        public object sum { get; set; }
        public string sum_text { get; set; }
    }

    public class Answers
    {
        public Choice[] choices { get; set; }
        public Row[] rows { get; set; }
        public Col[] cols { get; set; }
    }

    public class Choice
    {
        public int position { get; set; }
        public bool visible { get; set; }
        public string text { get; set; }
        public Quiz_Options quiz_options { get; set; }
        public string id { get; set; }
        public bool is_na { get; set; }
        public int weight { get; set; }
        public string description { get; set; }
    }

    public class Quiz_Options
    {
        public int score { get; set; }
    }

    public class Row
    {
        public int position { get; set; }
        public bool visible { get; set; }
        public string text { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public bool required { get; set; }
    }

    public class Col
    {
        public int position { get; set; }
        public bool visible { get; set; }
        public string text { get; set; }
        public string id { get; set; }
        public Choice1[] choices { get; set; }
    }

    public class Choice1
    {
        public int position { get; set; }
        public bool visible { get; set; }
        public string text { get; set; }
        public string id { get; set; }
        public bool is_na { get; set; }
    }

    public class Display_Options
    {
        public Custom_Options custom_options { get; set; }
        public string display_subtype { get; set; }
        public string display_type { get; set; }
        public File_Upload_Labels file_upload_labels { get; set; }
        public string left_label { get; set; }
        public string left_label_id { get; set; }
        public string middle_label { get; set; }
        public string middle_label_id { get; set; }
        public string right_label { get; set; }
        public string right_label_id { get; set; }
        public bool show_display_number { get; set; }
    }

    public class Custom_Options
    {
        public string color { get; set; }
        public object[] option_set { get; set; }
        public int starting_position { get; set; }
        public int step_size { get; set; }
    }

    public class File_Upload_Labels
    {
    }

    public class Heading
    {
        public string heading { get; set; }
    }
}
