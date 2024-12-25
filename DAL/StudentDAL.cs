using DAL.Models;
using System.Collections.Generic;
using System.Linq;
namespace DAL
{
    public class StudentDAL
    {
        private readonly SinhVienDbContext _context;

        public StudentDAL()
        {
            _context = new SinhVienDbContext();
        }

        public List<dynamic> GetAllStudents()
        {
            return _context.Students.Select(s => new
            {
                s.StudentID,
                s.FullName,
                s.MajorID,
                s.AverageScore,
                MajorName = s.Major != null ? s.Major.Name : "N/A"
            }).ToList<dynamic>();
        }


        public List<Student> GetStudentsWithoutMajor()
        {
            return _context.Students.Where(s => s.MajorID == null).ToList();
        }
        public bool DeleteStudent(int studentID)
        {
            var student = _context.Students.Find(studentID);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void AddOrUpdateStudent(Student student)
        {
            if (student.StudentID == 0)
            {
                _context.Students.Add(student);
            }
            else
            {
                _context.Entry(student).State = System.Data.Entity.EntityState.Modified;
            }
            _context.SaveChanges();
        }
    }
}