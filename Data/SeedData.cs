using CourseCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseCatalog.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CourseCatalogContext(
                   serviceProvider.GetRequiredService<DbContextOptions<CourseCatalogContext>>()))
        {
            if (context == null || context.Course == null)
            {
                throw new ArgumentNullException("Null Context"); 
            }

            if (context.Course.Any())
            {
                return; 
            }
            context.Course.AddRange(
                new Course()
                {
                    CourseName = "C# ", 
                    CourseDescription = "Covering C# topics",
                    Id = 1000,
                    StartTime = new TimeOnly(02,00),
                    RoomNumber = 200
                },
                new Course()
                {
                    CourseName = "Java ", 
                    CourseDescription = "Covering Java topics",
                    Id = 2000,
                    StartTime = new TimeOnly(12,00),
                    RoomNumber = 200
                },
                new Course()
                {
                    CourseName = "Cobol", 
                    CourseDescription = "Covering Cobol topics",
                    Id = 3000,
                    StartTime = new TimeOnly(04,00),
                    RoomNumber = 200
                },
                new Course()
                {
                    CourseName = "JavaScript", 
                    CourseDescription = "Covering JavaScript topics",
                    Id = 4000,
                    StartTime = new TimeOnly(03,00),
                    RoomNumber = 200
                },
                new Course()
                {
                    CourseName = "Python", 
                    CourseDescription = "Covering Python topics",
                    Id = 5000,
                    StartTime = new TimeOnly(01,00),
                    RoomNumber = 200
                }
                );
            context.SaveChanges(); 
        }
    }
}