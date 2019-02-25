using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Unittest af Bil pris.
        /// </summary>
        [TestMethod]
        public void PrisTestBil()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            decimal pris = bil.Pris();
            //Assert
            Assert.AreEqual(240, pris);
        }
        /// <summary>
        /// Unittest af Bil k�ret�j.
        /// </summary>
        [TestMethod]
        public void K�ret�jTestBil()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            string k�ret�j = bil.K�ret�j();
            //Assert
            Assert.AreEqual("Bil", k�ret�j);
        }
        /// <summary>
        /// Unittest af MC pris.
        /// </summary>
        [TestMethod]
        public void PrisTestMC()
        {
            //Arrange
            MC mc = new MC();
            //Act
            decimal pris = mc.Pris();
            //Assert
            Assert.AreEqual(125, pris);
        }
        /// <summary>
        /// Unittest af MC k�ret�j.
        /// </summary>
        [TestMethod]
        public void K�ret�jTestMC()
        {
            //Arrange
            MC mc = new MC();
            //Act
            string k�ret�j = mc.K�ret�j();
            //Assert
            Assert.AreEqual("MC", k�ret�j);
        }
    }
}
