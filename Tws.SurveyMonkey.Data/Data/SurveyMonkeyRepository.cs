using Tws.SurveyMonkey.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Tws.SurveyMonkey.Data.Data
{
    using SurveySet = NaturalEntitySet<ISMObjectId, SMSurvey, SMObjectIdComparer>;
    using SurveyCollectorSet = NaturalEntitySet<ISMObjectId, SMCollector, SMObjectIdComparer>;
    using CollectorRecipientSet = NaturalEntitySet<ISMObjectId, SMRecipient, SMObjectIdComparer>;
    using SurveyPageSet = NaturalEntitySet<ISMObjectId, SMPage, SMObjectIdComparer>;
    using SurveyQuestionSet = NaturalEntitySet<ISMObjectId, SMQuestion, SMObjectIdComparer>;
    using SurveyQuestionChoiceSet = NaturalEntitySet<ISMObjectId, SMChoice, SMObjectIdComparer>;
    using SurveyReponseSet = NaturalEntitySet<ISMObjectId, SMResponse, SMObjectIdComparer>;
    public interface IRepository
    {
        SurveySet SurveySet { get; }
        SurveyPageSet SurveyPageSet { get; }
        SurveyQuestionSet SurveyQuestionSet { get; }
        SurveyQuestionChoiceSet SurveyQuestionChoiceSet { get; }
        SurveyReponseSet SurveyReponseSet { get; }
        SurveyCollectorSet SurveyCollectorSet { get; }
        CollectorRecipientSet CollectorRecipientSet { get; }    
        Task LoadSurveyMonkeyEntities();

        Task InsertResponses(IEnumerable<SMResponse> responses);
    }
    public class SurveyMonkeyRepository : IRepository
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        public SurveySet SurveySet { get; }
        public SurveyPageSet SurveyPageSet { get; }
        public SurveyQuestionSet SurveyQuestionSet { get; }
        public SurveyQuestionChoiceSet SurveyQuestionChoiceSet { get; }
        public SurveyReponseSet SurveyReponseSet { get; }
        public SurveyCollectorSet SurveyCollectorSet { get; }
        public CollectorRecipientSet CollectorRecipientSet { get; }

        public SurveyMonkeyRepository(ISqlConnectionFactory connectionFactory)
        {
            this._connectionFactory = connectionFactory;

            SurveySet = new SurveySet(_connectionFactory, Sql.SurveyInsert, Sql.SurveySelectAll);
            SurveyCollectorSet = new SurveyCollectorSet(_connectionFactory, Sql.SurveyCollectorInsert, Sql.SurveyCollectorSellectAll);
            SurveyPageSet = new SurveyPageSet(_connectionFactory, Sql.SurveyPageInsert, Sql.SurveyPageSelectAll);
            SurveyQuestionSet = new SurveyQuestionSet(_connectionFactory, Sql.SurveyQuestionInsert, Sql.SurveyQuestionSelectAll);
            SurveyQuestionChoiceSet = new SurveyQuestionChoiceSet(_connectionFactory, Sql.SurveyQuestionChoiceInsert, Sql.SurveyQuestionChoiceSelectAll);
            SurveyReponseSet = new SurveyReponseSet(_connectionFactory, Sql.SurveyResponseInsert, Sql.SurveyResponseSelectAll);
            CollectorRecipientSet = new CollectorRecipientSet(_connectionFactory, Sql.CollectorRecipientInsert, Sql.CollectorRecipientSelectAll);
        }

        public async Task LoadSurveyMonkeyEntities()
        {
            _logger.Info("Start Loading Sets");
            try
            {
                var tasks = new[]
                {
                    SurveySet.Load(),
                    SurveyPageSet.Load(),
                    SurveyQuestionSet.Load(),
                    SurveyQuestionChoiceSet.Load(),
                    SurveyCollectorSet.Load(),
                    CollectorRecipientSet.Load()
                };

                await Task.WhenAll(tasks);
            }
            catch (Exception ex)
            {
                _logger.Error("Error loading Survey Monkey Entities {@error}", ex);
            }
            _logger.Info("Finish Loading Sets");
        }

        public Task InsertResponses(IEnumerable<SMResponse> responses)
        {
            string sql = "INSERT INTO Users (UserName) Values (@UserName);";
            var connection = _connectionFactory.CreateConnection();

            //connection.ExecuteAsync()

            return Task.FromResult(0);
        }
    }
}
