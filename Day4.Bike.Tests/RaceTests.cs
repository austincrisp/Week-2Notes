using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day4.Bike.Tests
{
    [TestClass]
    public class RaceTests
    {
        [TestMethod]
        public void RaceCanIdentifyWinner()
        {
            int finishLine = 10;
            bool isRunning = true;
            var bike = new Bike();

            bike.location = 40;

            isRunning = Program.TickRace(bike, isRunning, finishLine);

            Assert.AreEqual(false, isRunning);
        }

        [TestMethod]
        public void RaceWillAdvanceBikeIfNotWinner()
        {
            int finishLine = 20;
            bool isRunning = true;
            var bike = new Bike();

            isRunning = Program.TickRace(bike, isRunning, finishLine);

            Assert.AreEqual(true, isRunning);
            Assert.AreEqual(1, bike.location);
        }
    }
}
