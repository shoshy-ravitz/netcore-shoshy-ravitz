﻿using swimmingLwssons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Core.InterfaceRepository
{
    public interface IStudentRepository
    {
        public List<Student> GetStudents();
        public Student GetStudentByCode(int Codestudent);
        public bool AddStudent(Student student);
        public bool UpdateStudent(int studentId, Student     student);
        public bool DeleteStudent(int Codestudent);
    }
}
