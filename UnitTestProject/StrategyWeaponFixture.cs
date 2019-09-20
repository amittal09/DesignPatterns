using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Strategy.Character;

namespace UnitTestProject
{
    [TestClass]
    public class StrategyWeaponFixture
    {
        #region TestKingWeapon
        [TestMethod]
        public void TestKingWeapon()
        {
            DesignPatterns.Strategy.Character.King KingWeapon = new King();
            Assert.AreEqual("I swing at thee with this sword!", KingWeapon.Fight());
        }
        #endregion//TestKingWeapon

        #region TestQueenWeapon
        [TestMethod]
        public void TestQueenWeapon()
        {
            DesignPatterns.Strategy.Character.Queen QueenWeapon = new Queen();
            Assert.AreEqual("I will knife thee, nave!", QueenWeapon.Fight());
        }
        #endregion//TestQueenWeapon

        #region TestKnightWeapon
        [TestMethod]
        public void TestKnightWeapon()
        {
            DesignPatterns.Strategy.Character.Knight KnightWeapon = new Knight();
            Assert.AreEqual("I shot my arrow at thee!", KnightWeapon.Fight());
        }
        #endregion//TestKnightWeapon

        #region TestTrollWeapon
        [TestMethod]
        public void TestTrollWeapon()
        {
            DesignPatterns.Strategy.Character.Troll TrollWeapon = new Troll();
            Assert.AreEqual("I will chop thine head off!", TrollWeapon.Fight());
        }
        #endregion//TestTrollWeapon
    }
}
