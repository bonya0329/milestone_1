using milestone_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace milestone_1.Services
{
    public interface StudentInterface
    {
        void Add(Student student);
        Task Save();
        Task<List<Student>> GetAll();
        Task<List<Student>> GetStudents(Expression<Func<Student, bool>> predicate);
    }
}
