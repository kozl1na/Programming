using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует проверку статистических данных.
    /// </summary>
    class ValueValidator
    {
        /// <summary>
        /// Проверяет строку по заданным границам.
        /// </summary>
        /// <param name="value">Число для проверки.</param>
        /// <param name="max">Верхняя граница.</param>
        /// <param name="propertyName">Имя объекта.</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentOutOfRangeException($"{propertyName} is expected to be less than {maxLength}");
            }
        }


        /// <summary>
        /// Проверяет находится ли чисто в нужном деапазоне.
        /// </summary>
        /// <param name="value">Число для проверки.</param>
        /// <param name="min">Нижняя граница.</param>
        /// <param name="max">Верхняя граница.</param>
        /// <param name="propertyName">Имя объекта.</param>
        public static void AssertStringOnLength(double value, int minLength, int maxLength, string propertyName)
        {
            if (value < minLength || value > maxLength)
            {
                throw new ArgumentOutOfRangeException($"{propertyName} is expected to be less than {minLength} and bigger than {maxLength}");
            }
        }

    }
}


