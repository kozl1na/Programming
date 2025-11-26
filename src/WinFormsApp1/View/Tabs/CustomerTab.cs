using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Лист покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Переменная типа Customer.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Get и set для списка покупателей.
        /// </summary>
        public List<Customer> Customers { get { return _customers; } set { _customers = value; } }


        public CustomerTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates object of Customer with the help of TextBox.
        /// </summary>
        private Customer AddItemsInfo()
        {
            string fullname = FullNameTextBox.Text;
            return new Customer(fullname);
        }

        /// <summary>
        /// Обновляет элементы в ItemsListBox.
        /// </summary>
        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear();

            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add($"{customer.Id} / {customer.Fullname}");
            }
        }

        /// <summary>
        /// Очищает информацию о покупателях в TextBox.
        /// </summary>
        private void ClearItemInfo()
        {
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
            IDTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию о покупателях в TextBox.
        /// </summary>
        private void UpdateItemInfo()
        {
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            IDTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.Fullname.ToString();
            Address selectedAddress = _currentCustomer.CustomerAddress;
            AddressControl.SelelctedTextBoxs();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Fullname = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаём список для проверки
                var textBoxes = new List<System.Windows.Forms.TextBox>
                { FullNameTextBox };
                bool ifRed = true;

                foreach (var textBox in textBoxes)
                {
                    if (textBox.BackColor == Color.LightPink)
                    {
                        ifRed = false;
                    }
                }

                // Проверка TextBoxes Если они пустые или красные 
                if (textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text)) && ifRed)
                {
                    Customer selectedCustomer = AddItemsInfo();
                    selectedCustomer.CustomerAddress = AddressControl.AddInfoFromTextBox();
                    _customers.Add(selectedCustomer);
                    UpdateListBox();
                }
                else
                {
                    throw new Exception("Incorrect values.");
                }
            }
            catch (Exception ex)
            {
                // Ошибка
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                // Обика: Элемент не выбран
                MessageBox.Show(
                    "You didnt choose an object to delete it.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            _customers.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
            ClearItemInfo();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                UpdateItemInfo();
            }
        }

        private void CustomerListBox_DoubleClick(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                UpdateListBox();
            }
        }
    }
}
