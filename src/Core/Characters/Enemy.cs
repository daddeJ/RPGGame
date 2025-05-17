namespace RPGGame.Core.Characters
{
    public class Enemy : Character
    {
        public Enemy(string name, int level, int maxHealth)
            : base(name, level, maxHealth) { }

        public override void Attack(Character target)
        {
            int damage = 10 + Level;
            Console.WriteLine($"{Name} snarls and attacks {target.Name} for {damage} damage.");
            target.TakeDamage(damage);
        }
    }
}