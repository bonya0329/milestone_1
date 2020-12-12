using milestone_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace milestone_1.Services
{
    public class StudentService
    {
        private readonly StudentInterface _studentInterface;
        public StudentService(StudentInterface studentInterface)
        {
            _studentInterface = studentInterface;
        }
        public async Task<List<Student>> GetStudents()
        {
            return await _studentInterface.GetAll();
        }

        public async Task AddAndSave(Student student)
        {
            _studentInterface.Add(student);
            await _studentInterface.Save();
        }
        public async Task<List<Student>> Search(string text)
        {
            text = text.ToLower();
            var searchedStudents = await _studentInterface.GetStudents(student => student.Name.ToLower().Contains(text)
                                            || student.SurName.ToLower().Contains(text));

            return searchedStudents;
        }
    }
}
