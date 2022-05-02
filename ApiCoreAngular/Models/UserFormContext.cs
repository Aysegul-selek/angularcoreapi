using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCoreAngular.Models
{
    public class UserFormContext : DbContext
    {
        public UserFormContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UserFormDetail> UserFormDetails { get; set; }
    }
}
