using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Содержит данные о заказе.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// id заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Время создания заказа.
        /// </summary>
        private readonly DateTime _date = DateTime.Now;

        /// <summary>
        /// Возвращает id заказа.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }

        /// <summary>
        /// Get и set для статуса заказа.
        /// </summary>
        public OrderStatus Status { get; set; } = OrderStatus.New;

        /// <summary>
        /// Get и set для адреса доставки.
        /// </summary>
        public Address Address { get; set; } = new Address();   

        /// <summary>
        /// Get и set для списка.                                 
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();


        /// <summary>
        /// Получение полной суммы товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items.Count != 0 && Items != null)
                {
                    double amount = 0.0;
                    foreach (var item in Items)
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="status">Статус заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        public Order(Address address, List<Item> items)        
        {
            _id = IdGenerator.GetNextId();
            Status = new OrderStatus();
            Address = address;
            _date = DateTime.Now;
            foreach (Item item in items)
            {
                Items.Add(item);
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса. <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Status = new OrderStatus();
            Items = new List<Item>();
        }

    }
}
