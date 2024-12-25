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
                s.Faculty.FacultyName,
                s.AverageScore,
                MajorID = s.MajorID != null ? s.Major.MajorID : -1,
                MajorName = s.Major != null ? s.Major.Name : "Chưa ĐKCN"
            }).ToList<dynamic>();
        }

        public List<Faculty> GetFaculties()
        {
            return _context.Faculties.ToList();
        }
        public List<dynamic> GetStudentsWithoutMajor()
        {
            return _context.Students.Where(s => s.MajorID == null).Select(s => new
            {
                s.StudentID,
                s.FullName,
                s.Faculty.FacultyName,
                s.AverageScore,
            }).ToList<dynamic>(); ;
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
            var existingStudent = _context.Students.Find(student.StudentID);

            if (existingStudent == null)
            {
                // Thêm mới sinh viên
                _context.Students.Add(student);
            }
            else
            {
                // Cập nhật thông tin sinh viên
                _context.Entry(existingStudent).CurrentValues.SetValues(student);

                // Đảm bảo Major được nạp lại đúng
                if (student.MajorID != null)
                {
                    existingStudent.Major = _context.Majors.Find(student.MajorID);
                }
                else
                {
                    existingStudent.Major = null;
                }
            }

            _context.SaveChanges();
        }
    }

    }