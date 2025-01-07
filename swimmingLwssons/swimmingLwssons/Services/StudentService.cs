using Microsoft.AspNetCore.Mvc;
using swimmingLwssons.Entities;
using System.Diagnostics.CodeAnalysis;

namespace swimmingLwssons.Services
{
    public class StudentService
    {
        private DataContext dataContext = new DataContext();

        public List<Student> GetStudent()
        {
            return DataContext.Students;
        }
        public Student GetStudentByCode(int codeStudent) 
        {
            return DataContext.Students.FirstOrDefault(s => s.CodeCourse == codeStudent);
        }
        public bool AddStudent(Student student)
        {
            //--------cheking if there is place in course---------
            DataContext.Students.Add(student);
            return true;
        }
        public bool UpdateStudent(int code,Student student)
        {
            foreach (Student s in DataContext.Students)
            {
                if(s.CodeStudent == code)
                {
                    s.CodeCourse=student.CodeCourse;
                    s.DateBirth=student.DateBirth;
                    s.ProofPayment=student.ProofPayment;
                    s.Price=student.Price;
                    s.CodeGroup=student.CodeGroup;
                    s.Name=student.Name;
                    s.Mark=student.Mark;
                    s.HealthFund=student.HealthFund;
                    s.Tz=student.Tz;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteStudent(int codeStudent)
        {
          return DataContext.Students.Remove(DataContext.Students.FirstOrDefault(c => c.CodeStudent == codeStudent));
        }
    }
}
