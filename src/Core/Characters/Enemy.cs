using RPGGame.Core.Services;

namespace RPGGame.Core.Characters
{
    public class Enemy : Character
    {
        public Enemy(string name, int level, int maxHealth)
            : base(name, level, maxHealth) { }
        public override void Attack(Character target, DiceRollService diceRollService)
        {
            int critRoll = diceRollService.Roll(1, 7);
            int damage = BaseAttackDamage;

            if (critRoll >= 6)
            {
                damage *= 3;
                Console.WriteLine("Critical Hit!");
            }

            Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage (Roll: {critRoll})");
            target.TakeDamage(damage);
        }
    }
}