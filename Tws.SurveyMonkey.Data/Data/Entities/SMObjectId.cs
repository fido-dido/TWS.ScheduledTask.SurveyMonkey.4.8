using Dapper;
using System.Data;
using NLog;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Tws.SurveyMonkey.Data.Entities
{
    public interface ISMObjectId
    {
        string ObjectId { get; }
    }
    public class SMObjectId : ISMObjectId
    {
        public SMObjectId(string objectId)
        {
            ObjectId = objectId;
        }

        public SMObjectId(ISMObjectId smStringEntityId)
        {
            ObjectId = smStringEntityId.ObjectId;
        }

        public string ObjectId { get; }
    }

    public sealed class SMObjectIdComparer : IEqualityComparer<ISMObjectId>
    {
        private readonly StringComparer _comparer = StringComparer.InvariantCultureIgnoreCase;
        public bool Equals(ISMObjectId x, ISMObjectId y)
        {
            return _comparer.Equals(x.ObjectId, y.ObjectId);
        }

        public int GetHashCode(ISMObjectId obj)
        {
            return obj.ObjectId.ToLower().GetHashCode();
        }
    }
}
