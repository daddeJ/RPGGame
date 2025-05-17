using RPGGame.Core.Characters;
using RPGGame.Core.Items;

namespace RPGGame.Core.Services
{
    public class BattleService
    {
        private readonly DiceRollService _diceRollService;
        public BattleService()
        {
            _diceRollService = new DiceRollService();
        }
        private static Random rng = new Random();
        public void StartBattle(Character hero, Character enemy)
        {
            Console.WriteLine("🎮 Battle Start!");
            var dice = new DiceRollService();

            // 🎲 Roll to decide who goes first
            bool heroGoesFirst = dice.Roll(1, 2) == 1;
            Console.WriteLine(heroGoesFirst ? $"{hero.Name} goes first!" : $"{enemy.Name} goes first!");

            Character first = heroGoesFirst ? hero : enemy;
            Character second = heroGoesFirst ? enemy : hero;

            while (!hero.IsDead && !enemy.IsDead)
            {
                first.DecideTurn(second, dice);
                if (!second.IsDead)
                {
                    second.DecideTurn(first, dice);
                }
            }

            var winner = hero.IsDead ? enemy : hero;
            Console.WriteLine($"\n🏆 {winner.Name} wins the battle!");
        }
    }
}