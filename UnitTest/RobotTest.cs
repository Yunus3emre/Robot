using ConsoleUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class RobotTest
    {
        [TestMethod]
        public void TestMove()
        {
            // Arrange
            string instructions = "LMLMLMLMM";
            var rover = new Robot(1, 2, 'N', 5, 5);

            // Act
            rover.Move(instructions);

            // Assert
            Assert.AreEqual(2, rover.x);
            Assert.AreEqual(3, rover.y);
            Assert.AreEqual('N', rover.orientation);
        }
        [TestMethod]
        public void TestMove2()
        {
            // Arrange
            string instructions = "MMRMMRMRRM";
            var rover = new Robot(3, 3, 'E', 5, 5);

            // Act
            rover.Move(instructions);

            // Assert
            Assert.AreEqual(5, rover.x);
            Assert.AreEqual(1, rover.y);
            Assert.AreEqual('E', rover.orientation);
        }
        [TestMethod]
        public void TestMove3()
        {
            // Arrange
            string instructions = "MMLMMMMLMMMM";
            var rover = new Robot(3, 3, 'N', 5, 5);

            // Act
            rover.Move(instructions);

            // Assert
            Assert.AreEqual(1, rover.x);
            Assert.AreEqual(1, rover.y);
            Assert.AreEqual('S', rover.orientation);
        }
        [TestMethod]
        public void TestMove5()
        {
            // Arrange
            string instructions = "MRMLMRMLMRMMLM";
            var rover = new Robot(1, 1, 'N', 5, 5);

            // Act
            rover.Move(instructions);

            // Assert
            Assert.AreEqual(5, rover.x);
            Assert.AreEqual(5, rover.y);
            Assert.AreEqual('N', rover.orientation);
        }
    }
}
