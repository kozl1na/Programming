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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        public List<Item> _items = new();

        /// <summary>
        /// Переменная типа Item.
        /// </summary>
        private Item _currentItem = new Item();

        /// <summary>
        /// Переменная типа Item.
        /// </summary>
        private Item _selectedItem = new Item();

        /// <summary>
        /// Get и set для списка товаров.
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value; } }

        public ItemsTab()
        {
            InitializeComponent();
            LoadCategoryComboBox();
        }

        /// <summary>
        /// Создает объекты элемента с помощью текстовых полей.
        /// </summary>
        private Model.Item AddItemsInfo()
        {
            string name = NameTextBox.Text;
            string description = DescriptionTextBox.Text;
            double cost = double.Parse(CostTextBox.Text);
            Category category = (Category)CategoryComboBox.SelectedItem;
            return new Model.Item(name, description, cost);
        }

        /// <summary>
        /// Добавляет элементы списка в ItemListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear();

            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add($"{item.Id} / {item.Name} / {item.Category}");
            }
        }

        /// <summary>
        /// Удаляет информацию об элементе из TextBoxes.
        /// </summary>
        private void ClearItemInfo()
        {
            IDTextBox.Clear();

            CostTextBox.Clear();
            CostTextBox.BackColor = Color.White;

            DescriptionTextBox.Clear();
            DescriptionTextBox.BackColor = Color.White;

            NameTextBox.Clear();
            NameTextBox.BackColor = Color.White;

            CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Обновление информации о товарах в TextBox.
        /// </summary>
        /// <param name="item">Обновляемая книга.</param>
        private void UpdateItemInfo(Item item)
        {
            IDTextBox.Text = item.Id.ToString();
            DescriptionTextBox.Text = item.Info.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name.ToString();
            CategoryComboBox.Text = item.Category.ToString();
        }

        private void NameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void CostTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Cost = double.Parse(CostTextBox.Text);
                CostTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                if (CostTextBox.Text != "")
                {
                    CostTextBox.BackColor = Color.LightPink;
                }
            }

        }

        private void DescriptionTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Info = DescriptionTextBox.Text;
                DescriptionTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                DescriptionTextBox.BackColor = Color.LightPink;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "No selected items.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            _items.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
            ClearItemInfo();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];
                UpdateItemInfo(_currentItem);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // список TextBoxes
                var TextBoxes = new List<TextBox> { CostTextBox, NameTextBox, DescriptionTextBox };
                bool RedBox = true;

                foreach (var TextBox in TextBoxes)
                {
                    if (TextBox.BackColor == Color.LightPink)
                    {
                        RedBox = false;
                    }
                }
                // Проверка на пустые или красные boxes.
                if (TextBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text))
                    && CategoryComboBox.SelectedItem != null && RedBox)
                {
                    Item selectedItem = AddItemsInfo();
                    selectedItem.Category = (Category)CategoryComboBox.SelectedItem;
                    _items.Add(selectedItem);
                    UpdateListBox();
                }
                else
                {
                    throw new Exception("Incorrect Values. ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void ItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                UpdateListBox();
                _currentItem = _selectedItem;
            }
        }

        /// <summary>
        /// Добавляет элементы категории в CategoryComboBox.
        /// </summary>
        private void LoadCategoryComboBox()
        {
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(item);
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem != null && ItemsListBox.SelectedItem != null)
            {
                _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
                UpdateItemInfo(_currentItem);
            }
        }
    }

}
