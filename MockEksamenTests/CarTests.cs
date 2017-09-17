using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockEksamen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarInstanceTest()
        {
            //Arrange & Act
            Owner owner = new Owner("Bymosevej 13", "Elisa", "12345678");
            Car car = new Car(Color.Black, 4, "Scoda", "AA12313", owner);
            //Assert
            Assert.IsNotNull(car);
        }

        [TestMethod()]
        public void CarInstanceWithoutOwnerTest()
        {
            //Arrange & Act
            Car car = new Car(Color.Black, 4, "Scoda", "AA12313");
            //Assert
            Assert.IsNotNull(car);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Car1DoorTest()
        {
            //Arrange & Act
            Owner owner = new Owner("Bymosevej 13", "Elisa", "12345678");
            Car car = new Car(Color.Black, 1, "Scoda", "AA12313", owner);
            //Assert
            //Vi forventer allerede en exception
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Car6DoorsTest()
        {
            //Arrange & Act
            Owner owner = new Owner("Bymosevej 13", "Elisa", "12345678");
            Car car = new Car(Color.Black, 6, "Scoda", "AA12313", owner);
            //Assert
            //Vi forventer allerede en exception
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void CarModelNullTest()
        {
            //Arrange & Act
            Owner owner = new Owner("Bymosevej 13", "Elisa", "12345678");
            Car car = new Car(Color.Black, 5, null, "AA12313", owner);
            //Assert
            //Vi forventer allerede en exception
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarRegistrationNrOver7Test()
        {
            //Arrange & Act
            Owner owner = new Owner("Bymosevej 13", "Elisa", "12345678");
            Car car = new Car(Color.Black, 4, "Scoda", "AA123134", owner);
            //Assert
            //Vi forventer allerede en exception
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarRegistrationNrUnder7Test()
        {
            //Arrange & Act
            Owner owner = new Owner("Bymosevej 13", "Elisa", "12345678");
            Car car = new Car(Color.Black, 4, "Scoda", "AA1231", owner);
            //Assert
            //Vi forventer allerede en exception
        }

        [TestMethod()]
        public void CarDoorsSetTest()
        {
            //Arrange
            Owner owner = new Owner("Bymosevej 13", "Elisa", "12345678");
            Car car = new Car(Color.Black, 4, "Scoda", "AA12313", owner);
            //Act
            car.Doors = 3;
            //Assert
            Assert.AreEqual(3, car.Doors);
        }

        [TestMethod()]
        public void CarModelSetTest()
        {
            //Arrange
            Owner owner = new Owner("Bymosevej 13", "Elisa", "12345678");
            Car car = new Car(Color.Black, 4, "Scoda", "AA12313", owner);
            //Act
            car.Model = "Toyota";
            //Assert
            Assert.AreEqual("Toyota", car.Model);
        }

        [TestMethod()]
        public void CarRegistrationNoSetTest()
        {
            //Arrange
            Owner owner = new Owner("Bymosevej 13", "Elisa", "12345678");
            Car car = new Car(Color.Black, 4, "Scoda", "AA12313", owner);
            //Act
            car.RegistrationNo = "AA32132";
            //Assert
            Assert.AreEqual("AA32132", car.RegistrationNo);
        }

    }
}