using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesStageManagerSupinfo.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesStageContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesStageContext>>()))

            {
                // Look for any movies.
                if (context.Stage.Any())
                {
                    return;   // DB has been seeded
                }


             
            }

              

              
            }
        }
    }

