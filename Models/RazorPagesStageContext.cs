using Microsoft.EntityFrameworkCore;


namespace RazorPagesStageManagerSupinfo.Models
{
    public class RazorPagesStageContext : DbContext
    {
        public RazorPagesStageContext(DbContextOptions<RazorPagesStageContext> options)
       : base(options)
        {
        }

        public DbSet<RazorPagesStageManagerSupinfo.Models.Stage> Stage { get; set; }


    }
}






