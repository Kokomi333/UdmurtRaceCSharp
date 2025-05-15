namespace lab3C_
{
    partial class TicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IdBusRaceComboBox = new ComboBox();
            IdClientComboBox = new ComboBox();
            DateDepartationPicker = new DateTimePicker();
            TimeDepartationPicker = new DateTimePicker();
            DateTimeLabel = new Label();
            TicketCostNumeric = new NumericUpDown();
            TicketCostLabel = new Label();
            label1 = new Label();
            NameClientTextBox = new TextBox();
            label2 = new Label();
            AdresClientText = new TextBox();
            label3 = new Label();
            PhoneNumberNumeric = new NumericUpDown();
            StatusText = new TextBox();
            label4 = new Label();
            label5 = new Label();
            DescriptionText = new TextBox();
            AddBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)TicketCostNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberNumeric).BeginInit();
            SuspendLayout();
            // 
            // IdBusRaceComboBox
            // 
            IdBusRaceComboBox.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            IdBusRaceComboBox.FormattingEnabled = true;
            IdBusRaceComboBox.Location = new Point(43, 87);
            IdBusRaceComboBox.Name = "IdBusRaceComboBox";
            IdBusRaceComboBox.Size = new Size(183, 32);
            IdBusRaceComboBox.TabIndex = 0;
            IdBusRaceComboBox.Text = "Номер рейса";
            IdBusRaceComboBox.SelectedIndexChanged += IdBusRaceComboBox_SelectedIndexChanged;
            // 
            // IdClientComboBox
            // 
            IdClientComboBox.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            IdClientComboBox.FormattingEnabled = true;
            IdClientComboBox.Location = new Point(348, 87);
            IdClientComboBox.Name = "IdClientComboBox";
            IdClientComboBox.Size = new Size(176, 32);
            IdClientComboBox.TabIndex = 1;
            IdClientComboBox.Text = "Номер клиента";
            IdClientComboBox.SelectedIndexChanged += IdClientComboBox_SelectedIndexChanged;
            // 
            // DateDepartationPicker
            // 
            DateDepartationPicker.Enabled = false;
            DateDepartationPicker.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            DateDepartationPicker.ImeMode = ImeMode.NoControl;
            DateDepartationPicker.Location = new Point(56, 200);
            DateDepartationPicker.Name = "DateDepartationPicker";
            DateDepartationPicker.Size = new Size(205, 32);
            DateDepartationPicker.TabIndex = 2;
            // 
            // TimeDepartationPicker
            // 
            TimeDepartationPicker.Enabled = false;
            TimeDepartationPicker.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            TimeDepartationPicker.Format = DateTimePickerFormat.Time;
            TimeDepartationPicker.Location = new Point(99, 238);
            TimeDepartationPicker.Name = "TimeDepartationPicker";
            TimeDepartationPicker.Size = new Size(96, 32);
            TimeDepartationPicker.TabIndex = 3;
            // 
            // DateTimeLabel
            // 
            DateTimeLabel.AutoSize = true;
            DateTimeLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            DateTimeLabel.Location = new Point(78, 149);
            DateTimeLabel.MaximumSize = new Size(150, 0);
            DateTimeLabel.Name = "DateTimeLabel";
            DateTimeLabel.Size = new Size(148, 48);
            DateTimeLabel.TabIndex = 4;
            DateTimeLabel.Text = "Дата и время отправления";
            // 
            // TicketCostNumeric
            // 
            TicketCostNumeric.DecimalPlaces = 2;
            TicketCostNumeric.Enabled = false;
            TicketCostNumeric.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            TicketCostNumeric.Location = new Point(99, 311);
            TicketCostNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            TicketCostNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TicketCostNumeric.Name = "TicketCostNumeric";
            TicketCostNumeric.Size = new Size(120, 32);
            TicketCostNumeric.TabIndex = 5;
            TicketCostNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TicketCostLabel
            // 
            TicketCostLabel.AutoSize = true;
            TicketCostLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            TicketCostLabel.Location = new Point(61, 284);
            TicketCostLabel.Name = "TicketCostLabel";
            TicketCostLabel.Size = new Size(200, 24);
            TicketCostLabel.TabIndex = 6;
            TicketCostLabel.Text = "Стоимость билета";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label1.Location = new Point(414, 131);
            label1.Name = "label1";
            label1.Size = new Size(51, 24);
            label1.TabIndex = 7;
            label1.Text = "Имя";
            // 
            // NameClientTextBox
            // 
            NameClientTextBox.Enabled = false;
            NameClientTextBox.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            NameClientTextBox.Location = new Point(357, 157);
            NameClientTextBox.Name = "NameClientTextBox";
            NameClientTextBox.Size = new Size(167, 32);
            NameClientTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label2.Location = new Point(343, 211);
            label2.Name = "label2";
            label2.Size = new Size(211, 24);
            label2.TabIndex = 9;
            label2.Text = "Адрес проживания";
            // 
            // AdresClientText
            // 
            AdresClientText.Enabled = false;
            AdresClientText.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            AdresClientText.Location = new Point(357, 238);
            AdresClientText.Name = "AdresClientText";
            AdresClientText.Size = new Size(167, 32);
            AdresClientText.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label3.Location = new Point(343, 283);
            label3.Name = "label3";
            label3.Size = new Size(231, 24);
            label3.TabIndex = 12;
            label3.Text = "Контактный телефон";
            // 
            // PhoneNumberNumeric
            // 
            PhoneNumberNumeric.Enabled = false;
            PhoneNumberNumeric.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            PhoneNumberNumeric.Location = new Point(366, 311);
            PhoneNumberNumeric.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            PhoneNumberNumeric.Minimum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            PhoneNumberNumeric.Name = "PhoneNumberNumeric";
            PhoneNumberNumeric.Size = new Size(167, 32);
            PhoneNumberNumeric.TabIndex = 13;
            PhoneNumberNumeric.Value = new decimal(new int[] { 1410065408, 2, 0, 0 });
            // 
            // StatusText
            // 
            StatusText.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            StatusText.Location = new Point(238, 402);
            StatusText.Name = "StatusText";
            StatusText.Size = new Size(148, 32);
            StatusText.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label4.Location = new Point(273, 375);
            label4.Name = "label4";
            label4.Size = new Size(78, 24);
            label4.TabIndex = 15;
            label4.Text = "Статус";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(247, 458);
            label5.Name = "label5";
            label5.Size = new Size(139, 24);
            label5.TabIndex = 16;
            label5.Text = "Примечания";
            // 
            // DescriptionText
            // 
            DescriptionText.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DescriptionText.Location = new Point(168, 500);
            DescriptionText.Name = "DescriptionText";
            DescriptionText.Size = new Size(313, 32);
            DescriptionText.TabIndex = 17;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(220, 612);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(166, 58);
            AddBtn.TabIndex = 18;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(11F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 735);
            Controls.Add(AddBtn);
            Controls.Add(DescriptionText);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(StatusText);
            Controls.Add(PhoneNumberNumeric);
            Controls.Add(label3);
            Controls.Add(AdresClientText);
            Controls.Add(label2);
            Controls.Add(NameClientTextBox);
            Controls.Add(label1);
            Controls.Add(TicketCostLabel);
            Controls.Add(TicketCostNumeric);
            Controls.Add(DateTimeLabel);
            Controls.Add(TimeDepartationPicker);
            Controls.Add(DateDepartationPicker);
            Controls.Add(IdClientComboBox);
            Controls.Add(IdBusRaceComboBox);
            Name = "TicketForm";
            Text = "Добавление билета";
            ((System.ComponentModel.ISupportInitialize)TicketCostNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox IdBusRaceComboBox;
        private ComboBox IdClientComboBox;
        private DateTimePicker DateDepartationPicker;
        private DateTimePicker TimeDepartationPicker;
        private Label DateTimeLabel;
        private NumericUpDown TicketCostNumeric;
        private Label TicketCostLabel;
        private Label label1;
        private TextBox NameClientTextBox;
        private Label label2;
        private TextBox AdresClientText;
        private Label label3;
        private NumericUpDown PhoneNumberNumeric;
        private TextBox StatusText;
        private Label label4;
        private Label label5;
        private TextBox DescriptionText;
        private Button AddBtn;
    }
}