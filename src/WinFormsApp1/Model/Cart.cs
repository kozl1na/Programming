using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Содержит данные о корзине клиентов.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Создаём список типа Item
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Get и set для Items.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Получает стоимость всех товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {   
                if (_items.Count != 0 && _items != null) 
                {
                    double amount = 0.0;
                    foreach (var item in _items)
                    {
                        amount += item.Cost;
                    }
                    return amount;

                } 
                else
                {
                    return 0.0;
                }
            }
        }



    }
}
