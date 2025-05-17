# 🗂 RPG Game Development Backlog

This backlog tracks the development progress of the RPG Console Game project using OOP and SOLID principles.

---

## ✅ DONE

- [x] Setup solution structure with `src/`, `tests/`, `.gitignore`, and `README.md`
- [x] Created base abstract `Character` class with properties/methods
- [x] Implemented subclasses `Hero` and `Enemy` from `Character`
- [x] Created `IItem` interface and implemented `HealthPotion`
- [x] Added Inventory system to `Character` (with item usage)
- [x] Designed and implemented `BattleService` with turn-based logic
- [x] Integrated item usage logic (HP < 50 triggers potion use with chance)
- [x] Used random chance logic in battle (`rng.NextDouble()`)
- [x] Initial commit to Git repository with proper structure

## FEAT Implement randomized turn order, dice roll attacks, critical hits, and health potion usage in BattleService and Character

- [x] Added dice roll mechanic for turn order and attack critical hits
- [x] Refactored DecideTurn logic to base Character class
- [x] Implemented health potion usage below 50% HP with chance roll
- [x] Battle output includes dice rolls, critical hits, healing, and final winner message
---

## 🔜 NEXT STEPS (PRIORITIZED)

### 📌 [P1] Feature: Add more items
- [ ] Implement `Bomb` item (deals damage to opponent)
- [ ] Implement `StrengthPotion` (boosts attack for next turn)
- [ ] Extend item usage logic in `BattleService` or `Character`

### 📌 [P2] Refactor: Delegate item decision logic
- [ ] Move item-usage conditions from `BattleService` to character behavior
- [ ] Create `DecideTurn()` method (polymorphism-friendly)

### 📌 [P3] Add Unit Tests (xUnit)
- [ ] Test `HealthPotion` usage logic
- [ ] Test `BattleService` outcomes (win/loss)
- [ ] Mock RNG to control outcomes

### 📌 [P4] Add Logging & Report System
- [ ] Store turn-by-turn actions in a log (e.g., List<string>)
- [ ] Print battle summary after the game ends

---

## 📝 FUTURE IDEAS

- [ ] Add `Skill` system (with mana cost)
- [ ] Add `Mana` and `Leveling` mechanics
- [ ] Implement enemy types with custom AI behavior
- [ ] Add support for multiple enemies
- [ ] Allow saving/loading of player character
- [ ] Export battle logs to a file
- [ ] Upgrade to GUI or MAUI (eventually)

---

## 🧪 Testing Notes

Use xUnit in `tests/RPGGame.Tests/`  
To run tests:
```bash
dotnet test
