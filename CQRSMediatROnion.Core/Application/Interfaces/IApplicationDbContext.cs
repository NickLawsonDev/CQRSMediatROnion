using CQRSMediatROnion.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediatROnion.Core.Application;

public interface IApplicationDbContext
{
    DbSet<Product> Products { get; }
    Task<int> SaveChangesAsync();
}