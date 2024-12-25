using DAL;
using DAL.Models;
using System.Collections.Generic;
namespace BUS
{
    public class StudentService
    {
        private readonly StudentDAL _studentDal;

        public StudentService()
        {
            _studentDal = new StudentDAL();
        }

        public List<dynamic> GetAllStudents()
        {
            return _studentDal.GetAllStudents();
        }
        public bool DeleteStudent(int studentID)
        {
            return _studentDal.DeleteStudent(studentID);
        }

        public List<Student> GetStudentsWithoutMajor()
        {
            return _studentDal.GetStudentsWithoutMajor();
        }

        public void SaveStudent(Student student)
        {
            _studentDal.AddOrUpdateStudent(student);
        }
    }
}