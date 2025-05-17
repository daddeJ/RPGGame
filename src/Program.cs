using RPGGame.Core.Characters;
using RPGGame.Core.Items;
using RPGGame.Core.Services;

var hero = new Hero("Aris", 1, 100);
var enemy = new Enemy("Goblin", 1, 75);

var potion = new HealthPotion();
hero.AddItem(potion);
enemy.AddItem(potion);

var battle = new BattleService();
battle.StartBattle(hero, enemy);