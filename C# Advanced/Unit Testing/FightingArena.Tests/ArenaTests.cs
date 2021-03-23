using FightingArena;
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class ArenaTests
    {
        private Warrior warrior;
        private Arena arena;

        private string name = "Svetlio";
        private int damage = 100;
        private int hp = 100;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CtorWhenInicializedCountWarriorsMustBeZero()
        {
            arena = new Arena();
            Assert.AreEqual(0, arena.Count);
        }

        [Test]
        public void CtorWhenInicializedWarriorsArenaNotNull()
        {
            arena = new Arena();
            Assert.NotNull(arena.Warriors);
        }

        [Test]
        public void EnrollWarriorThrowExceptionWhenWarriorNameAlreadyExist()
        {
            arena = new Arena();

            warrior = new Warrior(name, damage, hp);
            arena.Enroll(warrior);

            Assert.Catch<InvalidOperationException>(() => arena.Enroll(new Warrior(name, damage + 10, hp + 10)));
        }

        [Test]
        public void EnrollWarriorToArenaIncreaseCount()
        {
            arena = new Arena();

            warrior = new Warrior(name, damage, hp);
            arena.Enroll(warrior);

            Assert.AreEqual(1, arena.Count);
        }

        [Test]
        public void EnrollWarriorToArenaCheckContainsInArena()
        {
            arena = new Arena();

            warrior = new Warrior(name, damage, hp);
            arena.Enroll(warrior);

            Assert.Contains(warrior, arena.Warriors.ToArray());
        }

        [Test]
        public void FightWarriorsThrowExceptionWhenAttackerWarriorNameDosntExist()
        {
            arena = new Arena();

            warrior = new Warrior(name, damage, hp);
            arena.Enroll(warrior);

            Assert.Catch<InvalidOperationException>(() => arena.Fight("RandomAtackerName", name));
        }

        [Test]
        public void FightWarriorsThrowExceptionWhenDefenderWarriorNameDosntExist()
        {
            arena = new Arena();

            warrior = new Warrior(name, damage, hp);
            arena.Enroll(warrior);

            Assert.Catch<InvalidOperationException>(() => arena.Fight(name, "RandomDefenderName"));
        }

        [Test]
        public void FightWarriorsThrowExceptionWhenAttackerAndDefenderWarriorNamesDosntExist()
        {
            arena = new Arena();

            warrior = new Warrior(name, damage, hp);
            arena.Enroll(warrior);

            Assert.Catch<InvalidOperationException>(() => arena.Fight("RandomDefenderName", "RandomDefenderName"));
        }

        [Test]
        public void FightWarriorsWhenBothNameExists()
        {
            arena = new Arena();

            Warrior attackerWarrior = new Warrior($"{name}Attacker", damage, hp);
            arena.Enroll(attackerWarrior);

            Warrior defenderWarrior = new Warrior($"{name}Defender", damage, hp);
            arena.Enroll(defenderWarrior);

            arena.Fight(attackerWarrior.Name, defenderWarrior.Name);
            Assert.AreEqual(0, defenderWarrior.HP);
            Assert.AreEqual(0, attackerWarrior.HP);
        }
    }
}
