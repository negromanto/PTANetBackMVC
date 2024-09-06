using Microsoft.EntityFrameworkCore;
using WebAPI_MVC_ASR.Models;

namespace WebAPI_MVC_ASR.Datos
{
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Constructor de la clase <see cref="ApplicationDbContext"/> con 
        /// inyección de la cadena de conexión a través de inyección de dependencias
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Feed> Feeds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feed>().HasData(FeedStore.CreatesAllFeeds());
        }


        
    }
}
