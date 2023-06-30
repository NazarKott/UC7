using US7.Models;

namespace UC7.UnitTests
{
    public class StudentConverterTests
    {
        [Fact]
        public void ConvertStudents_WhenAgeIs21AndGradeOver90_HonorRollShouldBeTrue()
        {
            // Arrange
            var studentConverter = new StudentConverter();
            var students = new List<Student>
            {
                new Student
                {
                    Name = "Test Student",
                    Age = 21,
                    Grade = 91
                }
            };

            // Act
            var convertedStudents = studentConverter.ConvertStudents(students);

            // Assert
            Assert.True(convertedStudents[0].HonorRoll);
        }

        [Fact]
        public void ConvertStudents_WhenAgeIsLessThan21AndGradeOver90_ExceptionalhouldBeTrue()
        {
            // Arrange
            var studentConverter = new StudentConverter();
            var students = new List<Student>
            {
                new Student
                {
                    Name = "Test Student",
                    Age = 20,
                    Grade = 91
                }
            };

            // Act
            var convertedStudents = studentConverter.ConvertStudents(students);

            // Assert
            Assert.True(convertedStudents[0].Exceptional);
        }

        [Fact]
        public void ConvertStudents_StudentWithGradeBetween71And90_PassedShouldBeTrue()
        {
            var studentConverter = new StudentConverter();
            var students = new List<Student>
            {
                new Student
                {
                    Name = "Test Student",
                    Age = 20,
                    Grade = 80
                }
            };

            // Act
            var convertedStudents = studentConverter.ConvertStudents(students);

            // Assert
            Assert.True(convertedStudents[0].Passed);
        }

        [Fact]
        public void ConvertStudents_StudentWithGrade70OrLess_PassedShouldBeFalse()
        {
            var studentConverter = new StudentConverter();
            var students = new List<Student>
            {
                new Student
                {
                    Name = "Test Student",
                    Age = 20,
                    Grade = 70
                }
            };

            // Act
            var convertedStudents = studentConverter.ConvertStudents(students);

            // Assert
            Assert.False(convertedStudents[0].Passed);
        }

        [Fact]
        public void ConvertStudents_EmptyArray_ShouldReturnEmptyArray()
        {
            // Arrange
            var studentConverter = new StudentConverter();
            var students = new List<Student>();

            // Act
            var convertedStudents = studentConverter.ConvertStudents(students);

            // Assert
            Assert.Empty(convertedStudents);
        }

        [Fact]
        public void ConvertStudents_NullInput_ShouldThrowException()
        {
            // Arrange
            var studentConverter = new StudentConverter();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => studentConverter.ConvertStudents(null));
        }
    }
}