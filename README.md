# Project Test Documentation

This documentation provides a description of the test classes and their associated test methods within the .NET project.

## Test Class: StudentConverterTests

### Test Method: ConvertStudents_WhenAgeIs21AndGradeOver90_HonorRollShouldBeTrue

- Description: This test verifies the behavior of the `ConvertStudents` method when the age of a student is 21 or above and their grade is over 90. It checks whether the `HonorRoll` property of the converted student is set to `true`.

### Test Method: ConvertStudents_WhenAgeIsLessThan21AndGradeOver90_ExceptionalShouldBeTrue

- Description: This test checks the behavior of the `ConvertStudents` method when the age of a student is less than 21 but their grade is over 90. It ensures that the `Exceptional` property of the converted student is set to `true`.

### Test Method: ConvertStudents_StudentWithGradeBetween71And90_PassedShouldBeTrue

- Description: This test validates the `ConvertStudents` method's handling of students whose grade falls between 71 and 90. It verifies that the `Passed` property of the converted student is set to `true`.

### Test Method: ConvertStudents_StudentWithGrade70OrLess_PassedShouldBeFalse

- Description: This test examines the behavior of the `ConvertStudents` method when a student's grade is 70 or less. It checks whether the `Passed` property of the converted student is set to `false`.

### Test Method: ConvertStudents_EmptyArray_ShouldReturnEmptyArray

- Description: This test ensures that the `ConvertStudents` method correctly handles an empty array input. It verifies that the method returns an empty array as the result.

### Test Method: ConvertStudents_NullInput_ShouldThrowException

- Description: This test validates that the `ConvertStudents` method throws an exception when a null input is provided. It checks for the expected exception to be raised.

## Test Class: PlayerAnalyzerTests

### Test Method: CalculateScore_SinglePlayerAge25Experience5Skills222_ShouldReturn250

- Description: This test calculates the score for a single player who is 25 years old, has 5 years of experience, and possesses skills represented by the values 2, 2, and 2. It verifies that the calculated score is 250.

### Test Method: CalculateScore_SinglePlayerAge15Experience3Skills333_Returns67_5

- Description: This test evaluates the score calculation for a single player aged 15, having 3 years of experience and skills represented by the values 3, 3, and 3. It checks whether the calculated score is 67.5.

### Test Method: CalculateScore_SinglePlayerAge35Experience15Skills444_Returns2520

- Description: This test examines the score calculation for a single player aged 35 with 15 years of experience and skills represented by the values 4, 4, and 4. It ensures that the calculated score is 2520.

### Test Method: CalculateScore_MultiplePlayers_ReturnsSumOfScores

- Description: This test calculates the scores for multiple players and verifies whether the method returns the sum of all the individual scores.

### Test Method: CalculateScore_PlayerWithNullSkills_ThrowsException

- Description: This test checks whether the `CalculateScore` method throws an exception when a player with null skills is passed as an argument.

### Test Method: CalculateScore_EmptyArray_Returns0

- Description: This test ensures that the `CalculateScore` method correctly handles an empty array input. It verifies that the method returns 0 as the score in such cases.

## Running Tests Locally

To run the tests locally in Visual Studio:

1. Open the solution file (.sln) of the .NET project in Visual Studio.
2. Build the solution to ensure all the necessary dependencies are resolved.
3. In the Test Explorer window, which can be accessed through the menu "Test" -> "Windows" -> "Test Explorer", you should see the list of available tests.
4. To run all the tests, click on the "Run All" button in the Test Explorer window.
5. To run a specific test, locate the desired test in the Test Explorer window and click on the "Run" button next to it.

To run the tests using the console:

1. Open a command prompt or terminal and navigate to the root directory of your .NET project.
2. Use the `dotnet test` command followed by the path to the test project or solution file. For example, `dotnet test MyProject.Tests.csproj`.
3. The console will display the test execution progress and the test results once completed.
