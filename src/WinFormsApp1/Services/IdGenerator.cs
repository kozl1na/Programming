using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует статистическую генерацию следующего номера для объекта.
    /// </summary>
    internal class IdGenerator
    {
        /// <summary>
        /// Счетчик для всех существующих объектов.
        /// </summary>
        private static int _nextId;

        /// <summary>
        /// Генерирует следующий номер.
        /// </summary>
        /// <returns>Возвращает следующий номер.</returns>
        public static int GetNextId()
        {
            return _nextId++;
        }
    }
}
