using LearnS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LearnS.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<AvatarsUpload> AvatarsUploads { get; set; }

        public DbSet<LearningMaterials> LearningMaterials { get; set; }
        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Question> Question { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Math", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Automatics", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Physics", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Section>().HasData(
                new Section
                {
                    Id = 1,
                    Title = "Statystyka",
                    Description = "Statystyka opisowa",
                    Author = "eTrapez",
                    CategoryId = 1
                },
                  new Section
                  {
                      Id = 2,
                      Title = "Statystyka",
                      Description = "Przedziały ufności. Estymacja przedziałowe.",
                      Author = "eTrapez",
                      CategoryId = 1
                  },
                    new Section
                    {
                        Id = 3,
                        Title = "Statystyka",
                        Description = "Parametryczne testy istotności",
                        Author = "eTrapez",
                        CategoryId = 1
                    }


                );
            modelBuilder.Entity<AvatarsUpload>().HasData(
                new AvatarsUpload
                {
                    Id = 1,
                    Name = "test",
                    ImageUrl = ""
                },
                new AvatarsUpload
                {
                    Id = 2,
                    Name = "kot",
                    ImageUrl = ""
                }
                );

            modelBuilder.Entity<LearningMaterials>().HasData(
                new LearningMaterials
                {
                    Id = 1,
                    Title = "statystyka",
                    Description = "test213",
                    Author = "eTrapez",
                    SectionId = 2

                }
                );


        }
    }
}
