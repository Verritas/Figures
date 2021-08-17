using System;

namespace FiguresLibrary.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Figure
    {
        #region fields

        private double a;

        private double b;

        private double c;

        #endregion

        #region properties

        /// <summary>
        /// Первая сторона
        /// </summary>
        public double A
        {
            get { return a; }
            set
            {
                if (value >= 0.0d) { a = value; }
                else { a = 0.0d; }
            }
        }

        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double B
        {
            get { return b; }
            set
            {
                if (value >= 0.0d) { b = value; }
                else { b = 0.0d; }
            }
        }

        /// <summary>
        /// Третья сторона
        /// </summary>
        public double C
        {
            get { return c; }
            set
            {
                if (value >= 0.0d) { c = value; }
                else { c = 0.0d; }
            }
        }

        #endregion

        /// <summary>
        /// Является ли прямоугольным
        /// </summary>
        public bool IsRight { get { if ((a>=b) && (a>=c)) return a * a == b * b + c * c; 
                                    if ((b>=a) && (b>=c)) return b * b == a * a + c * c;
                                    if ((c >= a) && (c >= a)) return c * c == a * a + b * b;

                                    return false;
                                  }
                            }

        #region methods

        #region public

        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        public override double GetArea()
        {
            double perimeter = a + b + c;
            double S = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
            
            return Math.Round(S, 3);
        }

        #endregion

        #endregion
    }
}
