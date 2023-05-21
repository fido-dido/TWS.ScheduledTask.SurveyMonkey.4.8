namespace Tws.SurveyMonkey.Data.Entities
{
    public static class Sql
    {
        public const string SurveySelectAll = "SELECT Id, SurveyEntityId, Title, Category, QuestionCount, PageCount, ResponseCount, CreatedDate, ModifiedDate FROM dbo.SMSurvey";
        public const string SurveyInsert = "INSERT dbo.SMSurvey(SurveyEntityId, Title, Category, QuestionCount, PageCount, ResponseCount, CreatedDate, ModifiedDate) OUTPUT INSERTED.* VALUES(@ObjectId, @Title, @Category, @QuestionCount, @PageCount, @ResponseCount, @CreatedDate, @ModifiedDate);";

        public const string SurveyPageSelectAll = @"SELECT Id, PageEntityId, SMSurveyId, Title, Description, QuestionCount, [Order] FROM dbo.SMPage";
        public const string SurveyPageInsert = "INSERT dbo.SMPage(PageEntityId, SMSurveyId, Title, Description, QuestionCount, [Order])  OUTPUT INSERTED.* VALUES(@ObjectId, @SMSurveyId, @Title, @Description, @QuestionCount, @Order);";
                                                  
        public const string SurveyQuestionSelectAll = @"SELECT Id, QuestionEntityId, SMPageId, QuestionType, Question, [Order] from dbo.SMQuestion";
        public const string SurveyQuestionInsert = "INSERT dbo.SMQuestion(QuestionEntityId, SMPageId, QuestionType, Question, [Order]) OUTPUT INSERTED.* VALUES(@ObjectId, @SMPageId, @QuestionType, @Question, @Order);";

        public const string SurveyCollectorSellectAll = @"SELECT Id, CollectorEntityId, SMSurveyId, Name, Type, Email FROM dbo.SMCollector";
        public const string SurveyCollectorInsert = "INSERT dbo.SMCollector(CollectorEntityId, SMSurveyId, Name, Type, Email) OUTPUT INSERTED.* VALUES(@ObjectId, @SMSurveyId, @Name, @Type, @Email);";

        public const string CollectorRecipientSelectAll = @"SELECT Id, RecipientEntityId, SMCollectorId, Email, PhoneNumber from dbo.SMRecipient";
        public const string CollectorRecipientInsert = "INSERT dbo.SMRecipient(RecipientEntityId, SMCollectorId, Email, PhoneNumber) OUTPUT INSERTED.* VALUES(@ObjectId, @SMCollectorId, @Email, @PhoneNumber);";
                                                          

        public const string SurveyQuestionChoiceSelectAll = @"select Id, ChoiceEntityId, SMQuestionId, Name, [Order] from dbo.SMChoice";
        public const string SurveyQuestionChoiceInsert = "INSERT dbo.SMChoice(ChoiceEntityId, SMQuestionId, Name, [Order]) OUTPUT INSERTED.* VALUES(@ObjectId, @SMQuestionId, @Name, @Order);";

        public const string SurveyResponseSelectAll = @"SELECT Id, EntityId, RecipientId, CollectionMode, ResponseStatus, CustomValue, FirstName, LastName, EmailAddress, IpAddress FROM dbo.SurveyResponse";
        public const string SurveyResponseInsert = "INSERT dbo.SurveyResponse( EntityId, RecipientId, CollectionMode, ResponseStatus, CustomValue, FirstName, LastName, EmailAddress, IpAddress) VALUES(@EntityId, @RecipientId, @CollectionMode, @ResponseStatus, @CustomValue, @FirstName, @LastName, @EmailAddress, @IpAddress); {SurveyResponseSelectAll} WHERE [EntityId] = @EntityId;";

    }
}
