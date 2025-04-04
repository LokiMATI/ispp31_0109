namespace LabWorkLibrary
{
    /// <summary>
    /// Математические действия
    /// </summary>
    public class Maths
    {
        /// <summary>
        /// Двоичный фактор
        /// </summary>
        public const short BINARY_FACTOR = 1024;

        /// <summary>
        /// Операция сложения
        /// </summary>
        /// <param name="x">Первое слагаемое</param>
        /// <param name="y">Второе слагаемое</param>
        /// <returns>Сумма</returns>
        public static double Add(double x, double y)
            => x + y;

        /// <summary>
        /// Операция вычитания
        /// </summary>
        /// <param name="x">Уменьшаемое</param>
        /// <param name="y">Вычитаемое</param>
        /// <returns>Разность</returns>
        public static double Subtract(double x, double y)
            => x - y;

        /// <summary>
        /// Операция умножения
        /// </summary>
        /// <param name="x">Первый множитель</param>
        /// <param name="y">Второй множитель</param>
        /// <returns>Произведение</returns>
        public static double Multiply(double x, double y)
            => x * y;

        /// <summary>
        /// Операция деления
        /// </summary>
        /// <param name="x">Делимое</param>
        /// <param name="y">Делитель</param>
        /// <exception cref="DivideByZeroException">Ситуация возникает, если в делитель передано значение 0.</exception>
        /// <returns>Частное</returns>
        public static double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException("Деление на ноль ЗАПРЕЩЕНО!");

            return x / y;
        }

        /// <summary>
        /// Получить площадь прямоугольника
        /// </summary>
        /// <param name="x">Высота</param>
        /// <param name="y">Ширина</param>
        /// <exception cref="ArgumentException">Если в параметры переданы значения меньшие или равные 0.</exception>
        /// <returns>Площадь</returns>
        public static double GetSquare(double x, double y)
        {
            if (x <= 0 || y <= 0)
                throw new ArgumentException("Параметры не могут быть меньше или равнятся нулю.");

            return x * y;
        }
    }
}
