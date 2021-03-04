using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashCow.Contracts.Persistence.CashCow;

namespace CashCow.Logic.Entity.CashCow
{
    internal partial class Partialpant : VersionEntity, IParticipant
    {
        public string Name { get; set; }
        public void CopyProperties(IParticipant other)
        {
            Id = other.Id;
            RowVersion = other.RowVersion;
            Name = other.Name;
        }
    }
}
