using EFCore01.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore01.Context;

internal class ITIDBContext : DbContext
{
    //Student
    public DbSet<Student> Students { get; set; };
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server = .; database = ITI; Trusted_Connection = true; TrustServerCertificate = true");
    }
}
