using System;
using NUnit.Framework;

namespace LB5_2.Tests
{
    public class StudentTests
    {
        private readonly string lineWithAllData = "Черемис Ростислав Олексійович M 27.05.2005 5 5 5 1500";
        
        [Test]
        public void PhysicsAverage_Should_Return_Average_When_Mark_Is_Provided()
        {
            var student = new Student(lineWithAllData);
            
            var result = student.PhysicsAverage();
            
            Assert.AreEqual(5, result);
        }
        
        [Test]
        public void PhysicsAverage_Should_Return_Zero_When_Mark_Is_Not_Provided()
        {
            const string lineWithoutPhysMark = "Черемис Ростислав Олексійович M 27.05.2005 5 - 5 1500";
            var student = new Student(lineWithoutPhysMark);
            
            var result = student.PhysicsAverage();
            
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestToString()
        {
            var student = new Student(lineWithAllData);
            
            var result = student.ToString();
            
            Assert.AreEqual(lineWithAllData, result);
        }

        [Test]
        public void TestIncorrectDataFormat()
        {
            const string lineWithIncorrectData = "Черемис Ростислав Олексійович M 272.05.2005 -1 - 5 7000";
            
            Assert.Throws<Exception>(() => new Student(lineWithIncorrectData));
        }
    }
}