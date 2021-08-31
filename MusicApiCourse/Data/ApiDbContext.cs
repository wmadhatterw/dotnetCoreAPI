using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicApiCourse.Models;

namespace MusicApiCourse.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext>options) : base(options)
        {
            
        }

        public DbSet<Song> Songs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Good Day Sunshine",
                    Language = "English",
                    Duration = "4:00"
                },
                new Song
                {
                    Id = 2,
                    Title = "BlackBird",
                    Language = "English",
                    Duration = "4:10"
                });


        }
    }
}
