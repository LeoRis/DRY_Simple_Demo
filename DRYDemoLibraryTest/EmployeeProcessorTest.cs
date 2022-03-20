using DRYDemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DRYDemoLibraryTest
{
    public class EmployeeProcessorTest
    {
        [Theory]
        [InlineData("John", "Smith", "JohnSmit")]
        [InlineData("Jos", "Verstappen", "JosXVers")]
        [InlineData("Jos", "Ve", "JosXVeXX")]
        public void GenerateEmployeeId_ShouldCalculate(string firstName, string lastName, string expectedStart)
        {
            // Arrange
            EmployeeProcessor processor = new EmployeeProcessor();

            // Act
            string actualStart = processor.GenerateEmployeeId(firstName, lastName).Substring(0, expectedStart.Length);

            // Assert
            Assert.Equal(expectedStart, actualStart);
        }
    }
}
