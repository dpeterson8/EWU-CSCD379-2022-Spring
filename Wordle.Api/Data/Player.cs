namespace Wordle.Api.Data
{
    public class Player
    {

        public string Name { get; set; } = null!;
        public int PlayerID { get; set; }
        public double AverageAttempts { get; set; }
        public int GameCount { get; set; }

        public Player Clone()
        {
            return new Player
            {
                Name = Name,
                PlayerID = PlayerID,
                AverageAttempts = AverageAttempts,
                GameCount = GameCount,

            };
        }

    }
}
