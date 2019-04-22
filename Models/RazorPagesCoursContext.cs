using Microsoft.EntityFrameworkCore;


namespace RazorPagesStageManagerSupinfo.Models
{
    public class RazorPagesCoursContext : DbContext
    {
        public RazorPagesCoursContext(DbContextOptions<RazorPagesCoursContext> options)
       : base(options)
        {
        }

        public DbSet<RazorPagesStageManagerSupinfo.Models.Cours> Cours { get; set; }
    }
}






