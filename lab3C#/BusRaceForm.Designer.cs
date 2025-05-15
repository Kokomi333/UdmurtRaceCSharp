namespace lab3C_
{
    partial class BusRaceForm
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
            DescriptionTextArea = new TextBox();
            TimeLabel = new Label();
            TimeRacePicker = new DateTimePicker();
            DateLabel = new Label();
            DateRacePicker = new DateTimePicker();
            label1 = new Label();
            DestinationTextArea = new TextBox();
            label2 = new Label();
            NumberOfSeatsNumeric = new NumericUpDown();
            label3 = new Label();
            TicketCostNumeric = new NumericUpDown();
            label4 = new Label();
            AddBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)NumberOfSeatsNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TicketCostNumeric).BeginInit();
            SuspendLayout();
            // 
            // DescriptionTextArea
            // 
            DescriptionTextArea.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            DescriptionTextArea.Location = new Point(115, 488);
            DescriptionTextArea.Name = "DescriptionTextArea";
            DescriptionTextArea.Size = new Size(154, 29);
            DescriptionTextArea.TabIndex = 11;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            TimeLabel.Location = new Point(127, 150);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(133, 22);
            TimeLabel.TabIndex = 0;
            TimeLabel.Text = "Время рейса";
            // 
            // TimeRacePicker
            // 
            TimeRacePicker.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            TimeRacePicker.Format = DateTimePickerFormat.Time;
            TimeRacePicker.Location = new Point(136, 175);
            TimeRacePicker.Name = "TimeRacePicker";
            TimeRacePicker.Size = new Size(105, 29);
            TimeRacePicker.TabIndex = 1;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            DateLabel.Location = new Point(136, 82);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(117, 22);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "Дата рейса";
            // 
            // DateRacePicker
            // 
            DateRacePicker.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            DateRacePicker.Location = new Point(91, 107);
            DateRacePicker.Name = "DateRacePicker";
            DateRacePicker.Size = new Size(200, 29);
            DateRacePicker.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.Location = new Point(112, 228);
            label1.Name = "label1";
            label1.Size = new Size(179, 22);
            label1.TabIndex = 4;
            label1.Text = "Пункт назначения";
            // 
            // DestinationTextArea
            // 
            DestinationTextArea.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            DestinationTextArea.Location = new Point(115, 253);
            DestinationTextArea.Name = "DestinationTextArea";
            DestinationTextArea.Size = new Size(176, 29);
            DestinationTextArea.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.Location = new Point(112, 392);
            label2.Name = "label2";
            label2.Size = new Size(173, 22);
            label2.TabIndex = 6;
            label2.Text = "Количество мест";
            // 
            // NumberOfSeatsNumeric
            // 
            NumberOfSeatsNumeric.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            NumberOfSeatsNumeric.Location = new Point(112, 417);
            NumberOfSeatsNumeric.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            NumberOfSeatsNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberOfSeatsNumeric.Name = "NumberOfSeatsNumeric";
            NumberOfSeatsNumeric.Size = new Size(176, 29);
            NumberOfSeatsNumeric.TabIndex = 7;
            NumberOfSeatsNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.Location = new Point(101, 305);
            label3.Name = "label3";
            label3.Size = new Size(239, 22);
            label3.TabIndex = 8;
            label3.Text = "Стоимость билета (Руб)";
            // 
            // TicketCostNumeric
            // 
            TicketCostNumeric.DecimalPlaces = 2;
            TicketCostNumeric.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            TicketCostNumeric.Location = new Point(115, 330);
            TicketCostNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            TicketCostNumeric.Name = "TicketCostNumeric";
            TicketCostNumeric.Size = new Size(176, 29);
            TicketCostNumeric.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.Location = new Point(112, 463);
            label4.Name = "label4";
            label4.Size = new Size(166, 22);
            label4.TabIndex = 10;
            label4.Text = "Описание рейса";
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            AddBtn.Location = new Point(115, 539);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(154, 60);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // BusRaceForm
            // 
            AutoScaleDimensions = new SizeF(11F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 657);
            Controls.Add(AddBtn);
            Controls.Add(DescriptionTextArea);
            Controls.Add(label4);
            Controls.Add(TicketCostNumeric);
            Controls.Add(label3);
            Controls.Add(NumberOfSeatsNumeric);
            Controls.Add(label2);
            Controls.Add(DestinationTextArea);
            Controls.Add(label1);
            Controls.Add(DateRacePicker);
            Controls.Add(DateLabel);
            Controls.Add(TimeRacePicker);
            Controls.Add(TimeLabel);
            Name = "BusRaceForm";
            Text = "Добавить рейс";
            ((System.ComponentModel.ISupportInitialize)NumberOfSeatsNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)TicketCostNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TimeLabel;
        private DateTimePicker TimeRacePicker;
        private Label DateLabel;
        private DateTimePicker DateRacePicker;
        private Label label1;
        private TextBox DestinationTextArea;
        private Label label2;
        private NumericUpDown NumberOfSeatsNumeric;
        private Label label3;
        private NumericUpDown TicketCostNumeric;
        private Label label4;
        private TextBox DescriptionTextArea;
        private Button AddBtn;
    }
}