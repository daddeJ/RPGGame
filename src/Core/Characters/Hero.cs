namespace RPGGame.Core.Characters
{
    public class Hero : Character
    {
        public Hero(string name, int level, int maxHealth)
            : base(name, level, maxHealth) { }

        public override void Attack(Character target)
        {
            int damage = 9 + Level;
            Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage");
            target.TakeDamage(damage);
        }
    }
}