using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUtilities.Tests
{
    [TestClass()]
    public class UtilitiesTests
    {
        [TestMethod()]
        public void WriteLineTest()
        {

            //Arrange 
            Utilities utilities = new Utilities();
            string stringHello = "Hello World";

            //Act
            string output = utilities.WriteLine(stringHello);

            //Assert
            Assert.AreEqual(stringHello, output);
        }
    }
}