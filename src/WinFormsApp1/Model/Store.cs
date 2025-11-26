using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товарах и покупателях.
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Get и set для списка товаров.
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value; } }

        /// <summary>
        /// Get и set для списка покупателей. 
        /// </summary>
        public List<Customer> Customers { get { return _customers; } set { _customers = value; } }

        /// <summary>
        /// Создаёт экзкмпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}
