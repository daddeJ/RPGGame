namespace RPGGame.Core.Services
{
    public class DiceRollService
    {
        private readonly Random _rng = new Random();
        public int Roll(int min = 1, int max = 7)
        {
            return _rng.Next(min, max + 1);
        }
    }
}