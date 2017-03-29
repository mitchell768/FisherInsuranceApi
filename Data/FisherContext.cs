using Microsoft.EntityFrameworkCore;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace FisherInsuranceApi.Data{
    
    
    public class FisherContext : IdentityDbContext<ApplicationUser>{
        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder) {
            string connection = "User ID=Fisher; Password=asm44512; Host=localhost; Port=5432; Database=Fisher-Insurance; Pooling=true;";

            optionsBuilder.UseNpgsql(connection);
        }
        public DbSet<Claim> Claims {get; set; }
        public DbSet<Quote> Quotes{get; set;}
     }
}
