using Foodit.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Foodit.Api.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
        : base(options)
        {

        }
     
        
        protected override void OnModelCreating(ModelBuilder builder) => base.OnModelCreating(builder);
        public DbSet<User> Users {get;set;}
        public DbSet<Item> Items {get;set;}
        public DbSet<Transaction> Transactions {get;set;}
    }
}