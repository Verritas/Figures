using FiguresLibrary.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsApp
{
    /// <summary>
    /// Unit-тесты
    /// </summary>
    [TestClass]
    public class Tests
    {
        /// <summary>
        /// Успешный расчет площади круга
        /// </summary>
        [TestMethod]
        public void AreaOfCircle()
        {
            var obj = new Circle
            {
                Radius = 3.0d
            };

            Assert.AreEqual(obj.GetArea(), 28.274);
        }

        /// <summary>
        /// Успешный расчет площади треугольника
        /// </summary>
        [TestMethod]
        public void AreaOfTriangle()
        {
            var obj = new Triangle
            {
                A = 2.0d,
                B = 3.0d,
                C = 4.0d
            };

            Assert.AreEqual(obj.GetArea(), 43.474);
        }

        /// <summary>
        /// Успешная проверка, что треугольник равносторонний
        /// </summary>
        [TestMethod]
        public void IsRight()
        {
            var obj = new Triangle
            {
                A = 3.0d,
                B = 4.0d,
                C = 5.0d
            };

            Assert.AreEqual(obj.IsRight, true);
        }

        /// <summary>
        /// Успешная проверка что треугольник не равносторонний
        /// </summary>
        [TestMethod]
        public void NotRight()
        {
            var obj = new Triangle
            {
                A = 3.0d,
                B = 4.0d,
                C = 3.0d
            };

            Assert.AreEqual(obj.IsRight, false);
        }

        /// <summary>
        /// Некорректное значение радиуса круга
        /// </summary>
        [TestMethod]
        public void ErrorInValueCircle()
        {
            var obj = new Circle
            {
                Radius = -53.0d
            };

            Assert.AreEqual(obj.Radius, 0.0d);
        }

        /// <summary>
        /// Некорректное значение длины стороны треугольника
        /// </summary>
        [TestMethod]
        public void ErrorInValueTriangle()
        {
            var obj = new Triangle
            {
                A = 4.0d,
                B = -54.2d,
                C = 32.2d
            };

            Assert.AreEqual(obj.B, 0.0d);
        }
    }
}
