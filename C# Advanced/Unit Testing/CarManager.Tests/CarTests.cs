using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private string make = "Mazda";
        private string model = "Z3";
        private double fuelConsumption = 5;
        private double fuelCapacity = 100;
        private double fuelAmount = 0;

        private Car car;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Constructor_SetAllProp()
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.AreEqual(car.Make, make);
            Assert.AreEqual(car.Model, model);
            Assert.AreEqual(car.FuelConsumption, fuelConsumption);
            Assert.AreEqual(car.FuelCapacity, fuelCapacity);
            Assert.AreEqual(car.FuelAmount, fuelAmount);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void MakePropertyThrowExceptionWhenNullOrEmpty(string make)
        {
            Assert.Catch<ArgumentException>(() => car = new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ModelPropertyThrowExceptionWhenNullOrEmpty(string model)
        {
            Assert.Catch<ArgumentException>(() => car = new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-2)]
        public void FuelConsumptionPropertyThrowExceptionWhenNegativeOrZero(double fuelConsumption)
        {
            Assert.Catch<ArgumentException>(() => car = new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-2)]
        public void FuelCapacityPropertyThrowExceptionWhenNegativeOrZero(double fuelCapacity)
        {
            Assert.Catch<ArgumentException>(() => car = new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-2)]
        public void RefuelThrowExceptionWhenGivenAmountIsNegativeOrZero(double fuelToRefuel)
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.Catch<ArgumentException>(() => car.Refuel(fuelToRefuel));
        }

        [Test]
        public void RefuelSetFuelAmountToFuelCapacityWhenCapacityExceeded()
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(fuelCapacity + 10);

            double fuelAfterRefuel = car.FuelAmount;
            Assert.AreEqual(fuelAfterRefuel, car.FuelCapacity);
        }

        [Test]
        public void RefuelAddFuelAmountWhenValid()
        {
            double fuel = 6;
            car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(fuel);
            car.Refuel(fuel);

            double fuelAfterRefuel = car.FuelAmount;
            Assert.AreEqual(fuelAfterRefuel, fuel * 2);
        }

        [Test]
        public void DriveThrowExceptionWhenNotEnoughFuel()
        {
            double distance = 100;
            car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.Catch<InvalidOperationException>(() => car.Drive(distance));
        }

        [Test]
        public void DriveDecreaseFuelAmountWhenEnoughFuel()
        {
            double distance = 100;
            car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(fuelCapacity);
            car.Drive(distance);

            double expectedFuelAmount = fuelCapacity - fuelConsumption;

            Assert.AreEqual(expectedFuelAmount, car.FuelAmount);
        }
    }
}