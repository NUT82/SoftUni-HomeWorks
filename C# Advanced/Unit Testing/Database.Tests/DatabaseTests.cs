using NUnit.Framework;
using DatabaseNS;
using System;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database database;
        private const int initialCapacity = 16;
        private int[] input = new int[initialCapacity];

        private Database emptyDatabase;

        [SetUp]
        public void Setup()
        {
            emptyDatabase = new Database();

            int value = 1;
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = value++;
            }

            database = new Database(input);
        }

        [Test]
        public void WhenGenerateNewDatabaseMustCreateEmptyBase()
        {
            Assert.AreEqual(0, emptyDatabase.Count);
        }

        [Test]
        public void TestIfFetchMethodReturnAllElementsAsArray()
        {
            Assert.AreEqual(input, database.Fetch());
        }

        [Test]
        public void TestAddElementToDatabase()
        {
            emptyDatabase.Add(1);
            Assert.AreEqual(1, emptyDatabase.Count);
            Assert.AreEqual(1, emptyDatabase.Fetch()[0]);
        }

        [Test]
        public void TestIfInvalidOperationExeptionIsThrownWhenAddingMoreElementsThenCapacity()
        {
            Assert.That(() => database.Add(1), Throws.InvalidOperationException.With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void TestRemoveElementFromLastPosition()
        {
            database.Remove();
            Assert.That(!database.Fetch().Contains(input[^1]));
        }

        [Test]
        public void TestWhenRemoveFromEmptyDatabaseIsThrownInvalidOperationExeption()
        {
            Assert.That(() => emptyDatabase.Remove(), Throws.InvalidOperationException.With.Message.EqualTo("The collection is empty!")); 
        }
    }
}