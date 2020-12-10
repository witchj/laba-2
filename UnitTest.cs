using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba2Task2;

namespace TestLaba2
{
    [TestClass]
    public class TeUnitTest
    {
        [TestMethod]
        public void testEmptyConstructor()
        {
            TETriangle a = new TETriangle();
            Assert.AreEqual(5,a.EdgeLength,"Дефолтное значение стороны не равно пяти");
        }
        
        [TestMethod]
        public void testEmptyConstructorPiramid()
        {
            TEPiramid a = new TEPiramid();
            Assert.AreEqual(5,a.EdgeLength, "Дефолтное значение стороны не равно пяти");
            Assert.AreEqual(5,a.Height, "Дефолтное значение высоты не равно пяти");
        }
        
        [TestMethod]
        public void testCopyConstructors()
        {
            TETriangle a = new TETriangle(10);
            TETriangle a1 = new TETriangle(a);
            Assert.AreEqual(a.EdgeLength, a1.EdgeLength, "Конструктор копирования не сработал");
        }
        
        [TestMethod]
        public void testCopyConstructorsPiramid()
        {
            TEPiramid a = new TEPiramid(10,15);
            TEPiramid a1 = new TEPiramid(a);
            Assert.AreEqual(a.EdgeLength, a1.EdgeLength,"Конструктор копирования не сработал");
            Assert.AreEqual(a.Height, a1.Height, "Конструктор копирования не сработал");
        }
        
        [TestMethod]
        public void testVolumePiramid()
        {
            TEPiramid a = new TEPiramid(10,15);
            Assert.AreEqual(216.50635094610968, a.Volume(),"Обьем неправильно посчитался");
        }

        [TestMethod]
        public void testAreaTriangle()
        {
            TETriangle a = new TETriangle(10);
            Assert.AreEqual(43.30127018922193, a.Area(),"Площадь неправильно ");
        }
    }
}
