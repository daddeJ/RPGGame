using RPGGame.Core.Interfaces;
namespace RPGGame.Core.Characters
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public List<IUsableItem> Inventory { get; private set; } = new List<IUsableItem>();
        public Character(string name, int level, int maxHealth)
        {
            Name = name;
            Level = level;
            MaxHealth = maxHealth;
            Health = maxHealth;
        }
        public abstract void Attack(Character target);

        public virtual void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0) Health = 0;
        }
        public bool IsDead => Health <= 0;
        public void Heal(int amount)
        {
            Health += amount;
            if (Health > MaxHealth)
                Health = MaxHealth;
        }
        public void AddItem(IUsableItem item)
        {
            Inventory.Add(item);
            Console.WriteLine($"{Name} picks up {item.Name}.");
        }
        public void UseItem(string itemName)
        {
            var item = Inventory.FirstOrDefault(i => i.Name == itemName);
            if (item != null)
            {
                item.Use(this);
                Inventory.Remove(item);
            }
            else
            {
                Console.WriteLine($"{Name} does not have {itemName}.");
            }
        }
    }
}