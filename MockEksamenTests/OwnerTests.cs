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
    public class OwnerTests
    {
        [TestMethod()]
        public void OwnerInstanceTest()
        {
            //Arrange & Act
            Owner owner = new Owner("Bymosevej 13", "Elisa", "12345678");
            //Assert
            Assert.IsNotNull(owner);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OwnerAddressUnder6Test()
        {
            //Arrange & Act
            Owner owner = new Owner("BYM", "Elisa", "12345678");
            //Assert
            //Vi forventer allerede en exception
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OwnerNameUnder4Test()
        {
            //Arrange & Act
            Owner owner = new Owner("Bymosevej 13", "Eli", "12345678");
            //Assert
            //Vi forventer allerede en exception
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OwnerPhoneUnder8Test()
        {
            //Arrange & Act
            Owner owner = new Owner("BYM", "Eli", "123456");
            //Assert
            //Vi forventer allerede en exception
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OwnerPhoneOver8Test()
        {
            //Arrange & Act
            Owner owner = new Owner("BYM", "Eli", "123456789");
            //Assert
            //Vi forventer allerede en exception
        }

        [TestMethod()]
        public void OwnerAddressSetTest()
        {
            //Arrange
            Owner owner = new Owner("Bymosevej 13", "Elisa", "12345678");
            //Act
            owner.Address = "Havelsevej 44";
            //Assert
            Assert.AreEqual("Havelsevej 44", owner.Address);
        }
    }
}