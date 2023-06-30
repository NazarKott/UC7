using US7.Models;

namespace UC7.UnitTests
{
    public class PlayerAnylyzerTests
    {
        [Fact]
        public void CalculateScore_SinglePlayerAge25Experience5Skills222_ShouldReturn250()
        {
            // Arrange
            var player = CreatePlayer("TestPlayer", 25, 5, new List<int> { 2, 2, 2 });

            var players = new List<Player> { player };
            var playerAnalyzer = new PlayerAnalyzer();

            // Act
            double score = playerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(250, score);
        }

        [Fact]
        public void CalculateScore_SinglePlayerAge15Experience3Skills333_Returns67_5()
        {
            // Arrange
            var player = CreatePlayer("TestPlayer", 15, 3, new List<int> { 3, 3, 3 });

            var players = new List<Player> { player };
            var playerAnalyzer = new PlayerAnalyzer();

            // Act
            double score = playerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(67.5, score);
        }

        [Fact]
        public void CalculateScore_SinglePlayerAge35Experience15Skills444_Returns2520()
        {
            // Arrange
            var player = CreatePlayer("TestPlayer", 35, 15, new List<int> { 4, 4, 4 });


            var players = new List<Player> { player };
            var playerAnalyzer = new PlayerAnalyzer();

            // Act
            double score = playerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(2520, score);
        }

        [Fact]
        public void CalculateScore_MultiplePlayers_ReturnsSumOfScores()
        {
            // Arrange
            var player1 = CreatePlayer("TestPlayer1", 25, 5, new List<int> { 2, 2, 2 });
            var player2 = CreatePlayer("TestPlayer1", 35, 15, new List<int> { 4, 4, 4 });

            var players = new List<Player> { player1, player2 };
            var playerAnalyzer = new PlayerAnalyzer();

            // Act
            double score = playerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(250 + 2520, score);
        }

        [Fact]
        public void CalculateScore_PlayerWithNullSkills_ThrowsException()
        {
            // Arrange
            var player = CreatePlayer("TestPlayer1", 25, 5, null);

            var players = new List<Player> { player };
            var playerAnalyzer = new PlayerAnalyzer();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => playerAnalyzer.CalculateScore(players));
        }

        [Fact]
        public void CalculateScore_EmptyArray_Returns0()
        {
            // Arrange
            var players = new List<Player>();
            var playerAnalyzer = new PlayerAnalyzer();

            // Act
            double score = playerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(0, score);
        }


        private Player CreatePlayer(string name, int age, int experience, List<int> skills)
        {
            return new Player()
            {
                Name = name,
                Age = age,
                Experience = experience,
                Skills = skills
            };
        }
    }
}