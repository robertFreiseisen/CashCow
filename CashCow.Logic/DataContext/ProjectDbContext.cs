using CashCow.Logic.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CashCow.Logic.DataContext
{
    internal partial class ProjectDbContext : DbContext, IContext
    {
    }
}
