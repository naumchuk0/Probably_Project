using AccessData.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Probably_Project.Data.Entities;

namespace Probably_Project.Data
{
    public class MovieDB : IdentityDbContext<User>
    {
        public MovieDB() { }
        public MovieDB(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=tcp:mysqlserve.database.windows.net,1433;Initial Catalog=MovieDB;Persist Security Info=False;User ID=Admin13@@mysqlserve;Password=Hasn1312@?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre() {Id = 1, Name = "Action"},
                new Genre() {Id = 2, Name = "Comedy"},
                new Genre() {Id = 3, Name = "Documentary"},
                new Genre() {Id = 4, Name = "Drama"},
                new Genre() {Id = 5, Name = "Fantasy"},
                new Genre() {Id = 6, Name = "Horror"},
                new Genre() {Id = 7, Name = "Musical"},
                new Genre() {Id = 8, Name = "Mystery"},
                new Genre() {Id = 9, Name = "Romance"},
                new Genre() {Id = 10, Name = "Science Fiction"},
                new Genre() {Id = 11, Name = "Thriller"},
                new Genre() {Id = 12, Name = "Western"}
            });

            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine"},
                new Country() { Id = 2, Name = "Ireland"},
                new Country() { Id = 3, Name = "Germany"},
                new Country() { Id = 4, Name = "China"},
                new Country() { Id = 5, Name = "USA"},
                new Country() { Id = 6, Name = "Japan"},
                new Country() { Id = 7, Name = "India"},
                new Country() { Id = 8, Name = "Mexico"},
                new Country() { Id = 9, Name = "Spain"},
                new Country() { Id = 10, Name = "Poland"},
                new Country() { Id = 11, Name = "Sweden"}
            });

        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Comment> Comments { get; set; }
    } 
}