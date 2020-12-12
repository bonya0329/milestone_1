using Microsoft.EntityFrameworkCore;
using milestone_1.Data;
using milestone_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace milestone_1.Services
{
    public class StudentRepository: StudentInterface
    {
        readonly StudentContext _context;

        public StudentRepository(StudentContext context)
        {
            _context = context;
        }
        public void Add(Student student)
        {
            _context.Add(student);
        }
        public Task<List<Student>> GetAll()
        {
            return _context.Students.ToListAsync();
        }

        public Task<List<Student>> GetStudents(Expression<Func<Student, bool>> predicate)
        {
            return _context.Students.Where(predicate).ToListAsync();
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}
