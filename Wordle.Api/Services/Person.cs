namespace Wordle.Api.Services
{
    public class Person
    {
        public string Name { get; set; }
        public int PlayerID { get; set; }
        public double AverageAttempts { get; set; }
        public int GameCount { get; set; }

        public Person(string name, int playerID, double averageAttempts, int gameCount)
        {
            Name = name;
            PlayerID = playerID;
            AverageAttempts = averageAttempts;
            GameCount = gameCount;
        }
    }
}
