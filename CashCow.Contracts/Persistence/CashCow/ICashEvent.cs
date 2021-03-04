using CommonBase.Attributes;
using System.Collections.Generic;

namespace CashCow.Contracts.Persistence.CashCow
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface ICashEvent : IVersionable, ICopyable<ICashEvent>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 256, IsUnique = true)]
        public string Title { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 1024, IsUnique = true)]
        public string Description { get; set; }
        public string Currency { get; set; }
        public List<IParticipant> Participants { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 64, IsUnique = true)]
        public string Category { get; set; }
    }
}
