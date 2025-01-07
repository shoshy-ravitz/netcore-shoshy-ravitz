using swimmingLwssons.Entities;

namespace swimmingLwssons.Services
{
    public class CourseService
    {
        private readonly IDataContext _contex;
        public CourseService(DataContext dataContext)
        {
            _contex = dataContext;
        }
        public List<Course> GetCourses()
        {
            return DataContext.Courses;
        }
        public Course GetCourseByCode(int CodeCourse)
        {
            return DataContext.Courses.FirstOrDefault((c) => c.CodeCourse == CodeCourse);
        }
        public bool AddCourse(Course course)
        {
            //---------cheking tz-------------//
            DataContext.Courses.Add(course);
            return true;
        }
        public bool UpdateCourse(int CourseId, Course course)
        {
            foreach (Course c in DataContext.Courses)
            {
                if (c.CodeCourse == CourseId)
                {
                    c.CountLessons = course.CountLessons;
                    c.KindSwim = course.KindSwim;
                    c.Price = course.Price;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteCourse(int CodeCourse)
        {
            return DataContext.Courses.Remove(DataContext.Courses.FirstOrDefault((c) => c.CodeCourse == CodeCourse));
        }
    }
}
