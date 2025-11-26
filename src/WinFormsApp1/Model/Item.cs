using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model {
    /// <summary>
    /// Хранит информацию о товарах.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Уникальный id товаров.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Имя товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описанеие товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает уникальный id товара.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Get и set для имени товара. Не более 200 символов.
        /// </summary>
        public string Name {
            get { return _name; }
            set {
                ValueValidator.AssertStringOnLength(value, 200, nameof(_name));
                _name = value;
                }
            }

        /// <summary>
        /// Get и set для описания товаров. Не более 1000 символов.
        /// </summary>
        public string Info {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(_info));
                _info = value;
            }
        }

        /// <summary>
        /// Get и set для цены товара. от 0 до 100000.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set {
                ValueValidator.AssertStringOnLength(value, 0, 100000, nameof(_cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Get и set для категорий товара. <see cref="Item"/>.
        /// </summary>
        public Category Category { get; set; }


        /// <summary>
        /// Создаёт экземпляр класса. <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Имя товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Цена товара.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
            Category = new Category();
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса. <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            Name = string.Empty;
            Info = string.Empty;
            Cost = 0;
            _id = IdGenerator.GetNextId();
            Category = new Category();
        }

    }
}