using RPGGame.Core.Characters;
using RPGGame.Core.Items;
namespace RPGGame.Core.Services
{
    public class BattleService
    {
        private static Random rng = new Random();
        public void StartBattle(Character attacker, Character defender)
        {
            Console.WriteLine("Battle Begin!");

            while (!attacker.IsDead && !defender.IsDead)
            {
                if (attacker.Health < 50)
                {
                    if (rng.NextDouble() <= 0.05)
                        attacker.UseItem("Health Potion");
                }
                if (defender.Health < 50)
                {
                    if (rng.NextDouble() <= 0.15)
                        defender.UseItem("Health Potion");
                }

                attacker.Attack(defender);
                if (!defender.IsDead)
                    defender.Attack(attacker);
            }

            var winner = attacker.IsDead ? defender : attacker;

            Console.WriteLine($"{winner.Name} wins the Battle!!");
        }
    }
}