using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private const int databaseCapacity = 16;
        private const long id = 123;
        private const string name = "Test";

        private Person person;
        private ExtendedDatabase.ExtendedDatabase extendedDatabase;
        private ExtendedDatabase.ExtendedDatabase fullExtendedDatabase;
        private ExtendedDatabase.ExtendedDatabase emptyExtendedDatabase;

        [SetUp]
        public void Setup()
        {
            person = new Person(id, name);
            extendedDatabase = new ExtendedDatabase.ExtendedDatabase();
            extendedDatabase.Add(person);

            emptyExtendedDatabase = new ExtendedDatabase.ExtendedDatabase();

            fullExtendedDatabase = new ExtendedDatabase.ExtendedDatabase();
            for (int i = 1; i <= databaseCapacity; i++)
            {
                person = new Person(id + i, name + i);
                fullExtendedDatabase.Add(person);
            }

            
        }

        [Test]
        public void CreatingNewPersonMustSetIdAndUserName()
        {
            person = new Person(id, name);
            Assert.AreEqual(person.Id, id);
            Assert.AreEqual(person.UserName, name);
        }

        [Test]
        public void AddPersonsMustThrowExeptionWhenCapacityExceeded()
        {
            Assert.Catch<InvalidOperationException>(() => fullExtendedDatabase.Add(person));
        }

        [Test]
        public void AddPersonsMustThrowExeptionWhenAddingPersonWithSameName()
        {
            Assert.Catch<InvalidOperationException>(() => extendedDatabase.Add(new Person(id + 1, name)));
        }

        [Test]
        public void AddPersonsMustThrowExeptionWhenAddingPersonWithSameId()
        {
            Assert.Catch<InvalidOperationException>(() => extendedDatabase.Add(new Person(id, name + 1)));
        }

        [Test]
        public void AddPersonMustIncreaseCountWhenIsValid()
        {
            extendedDatabase.Add(new Person(id + 1, name + 1));
            Assert.AreEqual(extendedDatabase.Count, 2);
        }

        [Test]
        public void AddPersonAddPersonCorectly()
        {
            person = new Person(id, name);
            emptyExtendedDatabase.Add(person);

            Assert.AreEqual(person, emptyExtendedDatabase.FindById(id));
        }

        [Test]
        public void AddRangeOfPeopleFromConstructorMustInicializeNewDatabaseWithEmptyCount()
        {
            Assert.AreEqual(emptyExtendedDatabase.Count, 0);
        }

        [Test]
        public void AddRangeOfPeopleFromConstructorMustIncreaseCountWithThisRange()
        {
            Person[] people = new Person[]
            {
                new Person(1, "Test1"),
                new Person(2, "Test2"),
                new Person(3, "Test3"),
            };

            extendedDatabase = new ExtendedDatabase.ExtendedDatabase(people);
            Assert.AreEqual(extendedDatabase.Count, 3);
        }

        [Test]
        public void AddRangeOfPeopleFromConstructorMustAddThemCorectly()
        {
            Person[] people = new Person[]
            {
                new Person(1, "Test1"),
                new Person(2, "Test2"),
                new Person(3, "Test3"),
            };

            extendedDatabase = new ExtendedDatabase.ExtendedDatabase(people);
            for (int i = 1; i <= 3; i++)
            {
                Assert.AreEqual(people[i - 1], extendedDatabase.FindById(i));
            }
        }


        [Test]
        public void AddRangeOfPeopleFromConstructorMustThrowExceptionWhenCapacityExceeded()
        {
            Person[] people = new Person[databaseCapacity];

            for (int i = 1; i <= databaseCapacity; i++)
            {
                people[i - 1] = new Person(id + i, name + i);
            }
            extendedDatabase = new ExtendedDatabase.ExtendedDatabase(people);


            Assert.Catch<InvalidOperationException>(() => extendedDatabase.Add(new Person(id, name)));
        }

        [Test]
        public void RemoveFromEmptyDatabaseMustThrowException()
        {
            Assert.Catch<InvalidOperationException>(() => emptyExtendedDatabase.Remove());
        }

        [Test]
        public void RemoveFromDatabaseMustDecreaseCount()
        {
            Person[] people = new Person[]
            {
                new Person(1, "Test1"),
                new Person(2, "Test2"),
                new Person(3, "Test3"),
            };

            extendedDatabase = new ExtendedDatabase.ExtendedDatabase(people);
            extendedDatabase.Remove();
            Assert.AreEqual(extendedDatabase.Count, 2);
        }

        [Test]
        public void RemoveFromDatabaseMustRemovePerson()
        {
            Person[] people = new Person[]
            {
                new Person(1, "Test1"),
                new Person(2, "Test2"),
                new Person(3, "Test3"),
            };

            extendedDatabase = new ExtendedDatabase.ExtendedDatabase(people);
            extendedDatabase.Remove();
            Assert.Catch<InvalidOperationException>(() => extendedDatabase.FindById(3));
        }

        [Test]
        public void FindByUsernameMustThrowExceptionWhenNameIsNullOrEmpty()
        {
            Assert.Catch<ArgumentNullException>(() => fullExtendedDatabase.FindByUsername(""));
            Assert.Catch<ArgumentNullException>(() => fullExtendedDatabase.FindByUsername(null));
        }

        [Test]
        public void FindByUsernameMustThrowExceptionWhenNameIsNotPresentInDatabase()
        {
            Assert.Catch<InvalidOperationException>(() => fullExtendedDatabase.FindByUsername("NotPresentUserName"));
        }

        [Test]
        public void FindByUsernameMustThrowExceptionWhenNameIsPresentInDatabaseButCheckCaseSensitive()
        {
            person = new Person(1, "Test");
            emptyExtendedDatabase.Add(person);

            Assert.Catch<InvalidOperationException>(() => emptyExtendedDatabase.FindByUsername("TEST"));
        }

        [Test]
        public void FindByUsernameMustReturnPersonWhenIsValid()
        {
            person = new Person(1, "Test");
            emptyExtendedDatabase.Add(person);
            Person findPersonByName = emptyExtendedDatabase.FindByUsername("Test");

            Assert.AreEqual(findPersonByName, person);
        }

        [Test]
        public void FindByIdMustThrowExceptionWhenIdIsNegative()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => fullExtendedDatabase.FindById(-1));
        }

        [Test]
        public void FindByIdMustThrowExceptionWhenIdIsNotPresentInDatabase()
        {
            Assert.Catch<InvalidOperationException>(() => fullExtendedDatabase.FindById(123456));
        }

        [Test]
        public void FindByIdMustReturnPersonWhenIdIsValid()
        {
            person = new Person(1, "Test");
            emptyExtendedDatabase.Add(person);
            Person findPersonById = emptyExtendedDatabase.FindById(1);

            Assert.AreEqual(findPersonById, person);
        }
    }
}