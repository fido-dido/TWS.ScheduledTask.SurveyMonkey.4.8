using Dapper;
using System.Data;
using NLog;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Tws.SurveyMonkey.Data.Entities
{
    public class EntitySet<T> where T : class, IEntityId
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        protected readonly string InsertSql;
        private readonly string _loadSql;
        protected IDictionary<int, T> KeyedDictionary = new Dictionary<int,T>();
        public ICollection<T> Entities => KeyedDictionary.Values;
       private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public EntitySet(ISqlConnectionFactory connectionFactory, string insertSql, string loadSql)
        {
            this._connectionFactory = connectionFactory;
            this.InsertSql = insertSql;
            this._loadSql = loadSql;
        }

        protected IDbConnection Connection => _connectionFactory.CreateConnection();

        public async Task<T> Item(int id)
        {
            _logger.Info("Loading Item {id}", id);
            await LoadCheck();
            _logger.Info("Returning Item {@id}", KeyedDictionary[id]);

            return KeyedDictionary[id];
        }

        protected async Task LoadCheck()
        {
            if (KeyedDictionary == null) await Load();
        }

        public virtual async Task Load()
        {
            _logger.Info("Start Load method");
            IEnumerable<T> items;
            try
            {
                items = await Connection.QueryAsync<T>(_loadSql);
            }
            catch (Exception ex)
            {
                _logger.Info("Error:{@error} LoadingLoaded", ex);
                throw;
            }

            foreach (var item in items)
            {
                KeyedDictionary.Add(item.Id, item);
            }
            _logger.Info("Loaded {count} items", KeyedDictionary.Count);
        }
    }
}
