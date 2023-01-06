using CQRSMediatROnion.Core.Application;
using CQRSMediatROnion.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediatROnion.Infrastructure.Persistence.Context;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<Product> Products => Set<Product>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    public async Task<int> SaveChangesAsync()
    {
        return await base.SaveChangesAsync();
    }
}