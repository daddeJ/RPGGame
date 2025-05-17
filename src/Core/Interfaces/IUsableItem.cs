using RPGGame.Core.Characters;

namespace RPGGame.Core.Interfaces
{
    public interface IUsableItem
    {
        string Name { get; }
        void Use(Character target);
    }
}