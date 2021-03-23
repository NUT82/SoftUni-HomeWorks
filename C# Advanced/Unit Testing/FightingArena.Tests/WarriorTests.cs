using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        private Warrior warrior;

        private const int MIN_ATTACK_HP = 30;

        private string name = "Svetlio";
        private int damage = 100;
        private int hp = 100;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorSetAllPropertyIfValid()
        {
            warrior = new Warrior(name, damage, hp);

            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(hp, warrior.HP);
        }

        [Test]
        [TestCase(null)]
        [TestCase("   ")]
        [TestCase("")]
        public void ConstructorThrowExceptionWhenNameIsNullOrWhiteSpace(string name)
        {
            Assert.Catch<ArgumentException>(() => warrior = new Warrior(name, damage, hp));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        public void ConstructorThrowExceptionWhenDamageIsNegativeOrZero(int damage)
        {
            Assert.Catch<ArgumentException>(() => warrior = new Warrior(name, damage, hp));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-5)]
        public void ConstructorThrowExceptionWhenHPIsNegative(int hp)
        {
            Assert.Catch<ArgumentException>(() => warrior = new Warrior(name, damage, hp));
        }

        [Test]
        [TestCase(MIN_ATTACK_HP)]
        [TestCase(MIN_ATTACK_HP - 5)]
        public void AttackThrowExceptionWhenCurrentWarriorHPIsLessOrEqualToMinAttackHP(int hp)
        {
            warrior = new Warrior(name, damage, hp);
            Warrior attackedWarrior = new Warrior($"{name}Attacked", damage, this.hp);

            Assert.Catch<InvalidOperationException>(() => warrior.Attack(attackedWarrior));
        }

        [Test]
        [TestCase(MIN_ATTACK_HP)]
        [TestCase(MIN_ATTACK_HP - 5)]
        public void AttackThrowExceptionWhenAttackedWarriorHPIsLessOrEqualToMinAttackHP(int hp)
        {
            warrior = new Warrior(name, damage, this.hp);
            Warrior attackedWarrior = new Warrior($"{name}Attacked", damage, hp);

            Assert.Catch<InvalidOperationException>(() => warrior.Attack(attackedWarrior));
        }

        [Test]
        public void AttackThrowExceptionWhenCurrentWarriorHPIsLessThanAttackedWarriorDamage()
        {
            warrior = new Warrior(name, damage, damage - 5);
            Warrior attackedWarrior = new Warrior($"{name}Attacked", damage, hp);

            Assert.Catch<InvalidOperationException>(() => warrior.Attack(attackedWarrior));
        }

        [Test]
        public void AttackDecreaseCurrentWarriorHPWithAttackedWarriorDamageWhenValid()
        {
            warrior = new Warrior(name, damage, hp);
            Warrior attackedWarrior = new Warrior($"{name}Attacked", damage, hp);

            int expectedHP = warrior.HP - attackedWarrior.Damage;
            warrior.Attack(attackedWarrior);

            Assert.AreEqual(expectedHP, warrior.HP);
        }

        [Test]
        public void AttackSetAttackedWarriorHPToZeroWhenWarriorDamageIsGreater()
        {
            warrior = new Warrior(name, damage + 10, hp);
            Warrior attackedWarrior = new Warrior($"{name}Attacked", damage, damage);

            warrior.Attack(attackedWarrior);

            Assert.AreEqual(0, attackedWarrior.HP);
        }

        [Test]
        public void AttackDecreaseAttackedWarriorHPWithWarriorDamageWhenValid()
        {
            warrior = new Warrior(name, damage, hp);
            Warrior attackedWarrior = new Warrior($"{name}Attacked", damage, hp);

            int expectedHP = attackedWarrior.HP - warrior.Damage;
            warrior.Attack(attackedWarrior);

            Assert.AreEqual(expectedHP, attackedWarrior.HP);
        }
    }
}