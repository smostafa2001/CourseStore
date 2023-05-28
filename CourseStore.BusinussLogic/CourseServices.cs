using CourseStore.DAL.DbContexts;
using CourseStore.DAL.Entities;

namespace CourseStore.BusinussLogic;
public class CourseServices
{
    private readonly CourseStoreDbContext _context;

    public CourseServices(CourseStoreDbContext context) => _context = context;

    public List<Course> AllCourses => _context.Courses.ToList();
}
