using SwimmingLesson.Core.InterfaceRepository;
using SwimmingLesson.Core.InterfaceService;
using SwimmingLesson.Data;
using swimmingLwssons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Service.Service
{
    public class CourseService : ICourseService
    {
         readonly IRepository<Course> _dataRepository;

        public CourseService(IRepository<Course> data)
        {
            _dataRepository = data;
        }
        public bool AddCourse(Course course)
        {
           return  _dataRepository.Add(course);
        }

        public bool DeleteCourse(int CodeCourse)
        {
            return _dataRepository.Delete(CodeCourse);
        }

        public Course GetCourseByCode(int CodeCourse)
        {
            return _dataRepository.GetByCode(CodeCourse);
        }

        public List<Course> GetCourses()
        {
            return _dataRepository.Get();
        }

        public bool UpdateCourse(int CourseId, Course course)
        {

            return _dataRepository.Update(CourseId, course);
        }
    }
}
