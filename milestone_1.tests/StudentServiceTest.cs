using milestone_1.Models;
using milestone_1.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace milestone_1.tests
{
    public class StudentServiceTest
    {
        [Fact]
        public async Task AddTest()
        {
            var fakeRepository = Mock.Of<StudentInterface>();
            var studentService = new StudentService(fakeRepository);

            var student = new Student() { Name = "test student" };
            await studentService.AddAndSave(student);
        }
       
    }
}
