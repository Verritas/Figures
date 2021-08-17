namespace TestsApp
{
    public class Program
    {
        /// <summary>
        /// Тестирование библиотеки
        /// </summary>
        public static void Main(string[] args)
        {
            var TestsClass = new Tests();

            TestsClass.AreaOfCircle();
            TestsClass.AreaOfTriangle();
            TestsClass.IsRight();
            TestsClass.NotRight();
            TestsClass.ErrorInValueCircle();
            TestsClass.ErrorInValueTriangle();
        }
    }
}
