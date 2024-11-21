using BlazorCRUDApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDApp.Infrastructure.Context
{
    public  class BlazorCRUDAPPDbContext : DbContext
    {
        public BlazorCRUDAPPDbContext(DbContextOptions<BlazorCRUDAPPDbContext> options):base(options)
        {

        }
        public DbSet<Students> Students { get; set; }
    }
}
