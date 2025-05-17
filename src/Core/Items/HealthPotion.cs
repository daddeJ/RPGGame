using RPGGame.Core.Characters;
using RPGGame.Core.Interfaces;

namespace RPGGame.Core.Items
{
    public class HealthPotion : IUsableItem
    {
        public string Name => "Health Potion";
        private int healingAmount = 30;
        public void Use(Character target)
        {
            Console.WriteLine($"{target.Name} uses a Health Potion and restores {healingAmount} HP!");
            target.Heal(healingAmount);
        }
    }
}