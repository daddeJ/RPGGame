using RPGGame.Core.Interfaces;
using RPGGame.Core.Services;

namespace RPGGame.Core.Characters
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int BaseAttackDamage { get; protected set; } = 10;
        public bool IsDead => Health <= 0;
        public List<IUsableItem> Inventory { get; private set; } = new List<IUsableItem>();
        public Character(string name, int level, int maxHealth)
        {
            Name = name;
            Level = level;
            MaxHealth = maxHealth;
            Health = maxHealth;
        }
        public abstract void Attack(Character target, DiceRollService diceRollService);
        public virtual void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0) Health = 0;
        }
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
        public virtual void DecideTurn(Character opponent, DiceRollService dice)
        {
            Console.WriteLine($"\n🔄 {Name}'s Turn!");

            if (ShouldUseHealthPotion(dice))
            {
                TryUseHealthPotion();
            }
            else
            {
                Attack(opponent, dice);
            }
        }

        protected virtual bool ShouldUseHealthPotion(DiceRollService dice)
        {
            return Health < MaxHealth / 2 && dice.Roll(1, 7) > 5;
        }

        protected virtual void TryUseHealthPotion()
        {
            UseItem("Health Potion");
        }
    }
}