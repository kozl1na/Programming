using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Services;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{

    /// <summary>
    /// Хранит информацию о покупателях.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный id покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// ФИО покупателя.
        /// </summary>
        private string _fullname = string.Empty;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address = new Address();


        /// <summary>
        /// Новая переменная типа Cart.                                 
        /// </summary>
        private Cart _cart = new Cart();

        /// <summary>
        /// Список заказов.                                            
        /// </summary>
        private List<Order> _orders = new List<Order>();


        /// <summary> 
        /// Get и set для данных в корзине.                                      
        /// </summary>
        public Cart CustomerCart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        /// <summary>
        /// Возвращает уникальный id покупателя.
        /// </summary>
        public int Id{ get { return _id; } }

        /// <summary>
        /// Get и set для адреса доставки.
        /// </summary>
        public Address CustomerAddress
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Get и set для ФИО покупателя. Не более 200 символов.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(_fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Gets and sets the list of orders.
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders; 
            }
            set
            {
                _orders = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="fullname">ФИО покупателя.</param>
         
        public Customer(string fullname)
        {
            Fullname = fullname;
            CustomerAddress = new Address();
            _id = IdGenerator.GetNextId();
            CustomerCart = new Cart();
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса. <see cref="Item"/>.
        /// </summary>
        public Customer()
        {
            Fullname = string.Empty;
            CustomerAddress = new Address();
            _id = IdGenerator.GetNextId();
            CustomerCart = new Cart();
            Orders = new List<Order>();
        }
    }
}

