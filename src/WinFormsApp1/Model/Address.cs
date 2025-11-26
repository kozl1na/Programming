using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит инфориацию об адресе.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна.
        /// </summary>
        private string _country = string.Empty;

        /// <summary>
        /// Город.
        /// </summary>
        private string _city = string.Empty;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street = string.Empty;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building = string.Empty;

        /// <summary>
        /// Ноиер квартиры.
        /// </summary>
        private string _apartment = string.Empty;

        /// <summary>
        /// Get и set для почтового индекса, должен быть 6 значный.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100000, 999999, "Index");
                _index = value;
            }
        }


        /// <summary>
        /// Get и set для страны. Не более 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "Country");
                _country = value;
            }
        }

        /// <summary>
        /// Get и set для города. Не более 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "City");
                _city = value;
            }
        }

        /// <summary>
        /// Get и set для улицы. Не более 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, "Street");
                _street = value;
            }
        }

        /// <summary>
        /// Get и set для номера дома. не более 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Building");
                _building = value;
            }
        }

        /// <summary>
        /// Get и set для номера квартиры. не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Apartment");
                _apartment = value;
            }
        }


        /// <summary>
        /// Конструктор класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер кватиры.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;    
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
        }

    }
}
