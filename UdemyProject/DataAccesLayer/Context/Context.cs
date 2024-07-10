using Microsoft.EntityFrameworkCore;
using UdemyProject.DataAccesLayer.Entities;

namespace UdemyProject.DataAccesLayer.Context
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=UdemyP;User Id=sa;Password=1StrongPwd!!;TrustServerCertificate=true;");
        }




        /*
         
            Controller : Back-end kodlarının yazıldığı alan         
         
         */
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Experience> Experiences{ get; set; }
        public DbSet<Feature> Features{ get; set; }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Portfolio> Portfolios{ get; set; }
        public DbSet<Skills> Skills{ get; set; }
        public DbSet<Social> Socials{ get; set; }
        public DbSet<Testimonial> Testimonials{ get; set; }
        

    }
}
