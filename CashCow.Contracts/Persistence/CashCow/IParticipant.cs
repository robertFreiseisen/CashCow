﻿using CommonBase.Attributes;

namespace CashCow.Contracts.Persistence.CashCow
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface IParticipant : IVersionable, ICopyable<IParticipant>
    {
        [ContractPropertyInfo(Required = true)]
        public string Name { get; set; }
    }
}