using Dapper;
using System.Data;
using NLog;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Tws.SurveyMonkey.Data.Entities
{
    public class NaturalEntitySet<TKey, TValue, Tcomparer> : EntitySet<TValue>
        where TValue : class, IEntityId, TKey
        where Tcomparer : IEqualityComparer<TKey>, new()
    {
        private readonly Tcomparer _comparer;
        private IDictionary<TKey, TValue> _naturalDictionary;
        private readonly Func<TKey, Object> _paramFunc;
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public NaturalEntitySet(ISqlConnectionFactory connectionFactory, string insertSql, string loadSql) : base(connectionFactory, insertSql, loadSql)
        {
            _comparer = new Tcomparer();
            _paramFunc = (naturalEntity => naturalEntity);
            _naturalDictionary = new Dictionary<TKey, TValue>(_comparer);
        }

        public async Task<TValue> Item(TKey naturalEntity)
        {
            await LoadCheck();

            return _naturalDictionary.ContainsKey(naturalEntity) ?
                _naturalDictionary[naturalEntity] :
                    string.IsNullOrEmpty(InsertSql) ? null :
                    await Insert(naturalEntity);
        }

        private async Task<TValue> Insert(TKey naturalEntity)
        {
            var newItem = await Connection.QueryFirstAsync<TValue>(InsertSql, _paramFunc(naturalEntity));

            KeyedDictionary.Add(newItem.Id, newItem);
            _naturalDictionary.Add(newItem, newItem);

            _logger.Info("Loaded {@item} items", newItem);

            return newItem;
        }

        public override async Task Load()
        {
            await base.Load();

            foreach (var item in KeyedDictionary.Values)
            {
                _naturalDictionary.Add(item, item);
            }
            _logger.Info("Loaded {count} items", _naturalDictionary.Count);
        }
    }

}
