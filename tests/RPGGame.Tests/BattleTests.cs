using Xunit;
using RPGGame.Core.Characters;
using RPGGame.Core.Services;

namespace RPGGame.Tests
{
    public class BattleTests
    {
        [Fact]
        public void Hero_ShouldWinAgainst_WeakEnemy()
        {
            // Given
            var hero = new Hero("TestHero", 5, 100);
            var enemy = new Enemy("Weakling", 1, 40);
            var battle = new BattleService();
            // When
            battle.StartBattle(hero, enemy);
            // Then
            Assert.False(hero.IsDead);
            Assert.True(enemy.IsDead);
        }
    }
}