using System;
using PageUp.Platform.Core.Identities;

namespace Framework
{
    public class ThingyAggregateId : AggregateId
    {
        public ThingyAggregateId(Guid value) : base(value)
        {
        }
    }
}
