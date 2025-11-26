namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DeliveryAddressLabel = new Label();
            PostIndexLabel = new Label();
            CountryLabel = new Label();
            StreetLabel = new Label();
            BuildingLabel = new Label();
            PostIndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            ApartmentLabel = new Label();
            ApartmentTextBox = new TextBox();
            SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.AutoSize = true;
            DeliveryAddressLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeliveryAddressLabel.Location = new Point(11, 12);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new Size(135, 20);
            DeliveryAddressLabel.TabIndex = 0;
            DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PostIndexLabel.Location = new Point(13, 49);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(79, 20);
            PostIndexLabel.TabIndex = 1;
            PostIndexLabel.Text = "Post index:";
            // 
            // CountryLabel
            // 
            CountryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CountryLabel.Location = new Point(11, 89);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(63, 20);
            CountryLabel.TabIndex = 2;
            CountryLabel.Text = "Country:";
            // 
            // StreetLabel
            // 
            StreetLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StreetLabel.AutoSize = true;
            StreetLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StreetLabel.Location = new Point(11, 123);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(55, 20);
            StreetLabel.TabIndex = 3;
            StreetLabel.Text = "Street: ";
            // 
            // BuildingLabel
            // 
            BuildingLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BuildingLabel.AutoSize = true;
            BuildingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BuildingLabel.Location = new Point(11, 165);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(71, 20);
            BuildingLabel.TabIndex = 4;
            BuildingLabel.Text = "Building: ";
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PostIndexTextBox.Location = new Point(97, 45);
            PostIndexTextBox.MaximumSize = new Size(193, 23);
            PostIndexTextBox.MinimumSize = new Size(54, 23);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(193, 23);
            PostIndexTextBox.TabIndex = 5;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CountryTextBox.Location = new Point(97, 83);
            CountryTextBox.MaximumSize = new Size(193, 23);
            CountryTextBox.MinimumSize = new Size(54, 23);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(193, 23);
            CountryTextBox.TabIndex = 6;
            CountryTextBox.TextChanged += CountyTextBox_TextxChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Location = new Point(97, 120);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(515, 27);
            StreetTextBox.TabIndex = 7;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // CityLabel
            // 
            CityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CityLabel.Location = new Point(347, 83);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(41, 20);
            CityLabel.TabIndex = 8;
            CityLabel.Text = "City: ";
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CityTextBox.Location = new Point(425, 83);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(188, 27);
            CityTextBox.TabIndex = 9;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BuildingTextBox.Location = new Point(97, 165);
            BuildingTextBox.MaximumSize = new Size(193, 23);
            BuildingTextBox.MinimumSize = new Size(54, 23);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(193, 23);
            BuildingTextBox.TabIndex = 10;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ApartmentLabel.Location = new Point(345, 167);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(87, 20);
            ApartmentLabel.TabIndex = 11;
            ApartmentLabel.Text = "Apartment: ";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ApartmentTextBox.Location = new Point(427, 165);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(187, 27);
            ApartmentTextBox.TabIndex = 12;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(ApartmentTextBox);
            Controls.Add(ApartmentLabel);
            Controls.Add(BuildingTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(CityLabel);
            Controls.Add(StreetTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(PostIndexTextBox);
            Controls.Add(BuildingLabel);
            Controls.Add(StreetLabel);
            Controls.Add(CountryLabel);
            Controls.Add(PostIndexLabel);
            Controls.Add(DeliveryAddressLabel);
            MinimumSize = new Size(446, 240);
            Name = "AddressControl";
            Size = new Size(634, 240);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DeliveryAddressLabel;
        private Label PostIndexLabel;
        private Label CountryLabel;
        private Label StreetLabel;
        private Label BuildingLabel;
        private TextBox PostIndexTextBox;
        private TextBox CountryTextBox;
        private TextBox StreetTextBox;
        private Label CityLabel;
        private TextBox CityTextBox;
        private TextBox BuildingTextBox;
        private Label ApartmentLabel;
        private TextBox ApartmentTextBox;
    }
}
