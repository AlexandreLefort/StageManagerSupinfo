using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesStageManagerSupinfo.Models
{
    public static class SeedData2
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new RazorPagesCoursContext(
            serviceProvider.GetRequiredService<DbContextOptions<RazorPagesCoursContext>>()))
            {
                if (context.Cours.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cours.AddRange(


                    new Cours
                    {
                        Titre = "When Harry Met Sally",
                        Salle = "b3",
                        Date = DateTime.Parse("1989-2-12"),
                        Language = "C",
                        Commentaire = "Romantic Comedy"


                    }
                      );


                context2.SaveChanges();
            }
        }
    }
}
