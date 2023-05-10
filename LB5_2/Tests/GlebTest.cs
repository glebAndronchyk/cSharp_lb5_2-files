using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace LB5_2.Tests
{
    public class GlebTest
    {
        Gleb gleb = new Gleb();
        private List<Student> students = new List<Student>
        {
            new Student("Черемис Ростислав Олексійович M 27.05.2005 5 5 5 1500"),
            new Student("Глущенко Євгеній Олексійович Ч 21.10.2001 4 4 4 2000"),
            new Student("Qw Er Ty Ч 31.12.2005 5 5 5 3000"),
        };
        
        [Test]
        public void Task_Should_Update_Scholarship_When_All_Mark_Are_High()
        {
            var expectedOutput = "Черемис Ростислав Олексійович M 27.05.2005 5 5 5 6000\nГлущенко Євгеній Олексійович Ч 21.10.2001 4 4 4 2000\nQw Er Ty Ч 31.12.2005 5 5 5 6000\n";
            
            gleb.Task(students);

            Assert.AreEqual(expectedOutput, gleb.result);
        }
    }
}