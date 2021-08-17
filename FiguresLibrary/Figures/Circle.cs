using System;

namespace FiguresLibrary.Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Figure
    {
        #region fields

        private double radius;

        #endregion

        #region properties

        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get { return radius; } 
                               set { if (value >= 0.0d) { radius = value; } 
                                     else { radius = 0.0d; }
                                    } 
        }

        #endregion

        #region methods

        #region public

        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        public override double GetArea()
        {
            return Math.Round(radius * radius * Math.PI, 3);
        }

        #endregion

        #endregion
        
    }
}
