using Wordle.Api.Data;

namespace Wordle.Api.Services
{
    public class PlayersService
    {
        public PlayersService(AppDbContext context)
        {
            _context = context;

        }

        private AppDbContext _context;

        public IEnumerable<Player> GetAverageAttempts()
        {
            var result = _context.Player.OrderBy(x => x.AverageAttempts/x.GameCount);
            return result;
        }

        public void Update(double attempts, int gamesPlayed)
        {
            if (attempts < 1 || attempts > 6)
            {
                throw new ArgumentException("Score must be between 1 and 6, and the admin password is 'password123''");
            }
            if (gamesPlayed < 1)
            {
                throw new ArgumentException("Seconds must be greater than 0");
            }
            var player = _context.Player.First(x => x.AverageAttempts == attempts);
            player = _context.Player.First(x => x.GameCount == gamesPlayed);
            _context.SaveChanges();
        }

        public static void Seed(AppDbContext context)
        {
            if (!context.Player.Any())
            {
                for (int i = 1; i <= 6; i++)
                {
                    context.Player.Add(new Player()
                    {
                        AverageAttempts = i,
                        GameCount = 0,
                    });

                }
                context.SaveChanges();
            }
        }
    }
}