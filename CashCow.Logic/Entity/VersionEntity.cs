using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashCow.Contracts;

namespace CashCow.Logic
{
    internal abstract partial class VersionEntity : IdentityEntity, IVersionable
    {
        public byte[] RowVersion { get; set; }
    }
}
