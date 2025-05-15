namespace lab3C_
{
    partial class ClientForm
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
            label1 = new Label();
            label2 = new Label();
            SurnameText = new TextBox();
            NameText = new TextBox();
            label3 = new Label();
            PatronymicText = new TextBox();
            label4 = new Label();
            EmailText = new TextBox();
            label5 = new Label();
            label6 = new Label();
            AdressText = new TextBox();
            AddBtn = new Button();
            PhoneNumberNumeric = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label1.Location = new Point(120, 82);
            label1.Name = "label1";
            label1.Size = new Size(107, 24);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label2.Location = new Point(139, 154);
            label2.Name = "label2";
            label2.Size = new Size(51, 24);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // SurnameText
            // 
            SurnameText.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            SurnameText.Location = new Point(74, 109);
            SurnameText.Name = "SurnameText";
            SurnameText.Size = new Size(186, 32);
            SurnameText.TabIndex = 2;
            // 
            // NameText
            // 
            NameText.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            NameText.Location = new Point(71, 181);
            NameText.Name = "NameText";
            NameText.Size = new Size(189, 32);
            NameText.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label3.Location = new Point(120, 228);
            label3.Name = "label3";
            label3.Size = new Size(106, 24);
            label3.TabIndex = 4;
            label3.Text = "Отчество";
            // 
            // PatronymicText
            // 
            PatronymicText.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            PatronymicText.Location = new Point(71, 255);
            PatronymicText.Name = "PatronymicText";
            PatronymicText.Size = new Size(192, 32);
            PatronymicText.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label4.Location = new Point(71, 305);
            label4.Name = "label4";
            label4.Size = new Size(209, 24);
            label4.TabIndex = 6;
            label4.Text = "Электронная почта";
            // 
            // EmailText
            // 
            EmailText.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            EmailText.Location = new Point(71, 332);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(209, 32);
            EmailText.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label5.Location = new Point(74, 384);
            label5.Name = "label5";
            label5.Size = new Size(186, 24);
            label5.TabIndex = 8;
            label5.Text = "Номер телефона";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label6.Location = new Point(74, 468);
            label6.Name = "label6";
            label6.Size = new Size(189, 24);
            label6.TabIndex = 10;
            label6.Text = "Домашний адрес";
            // 
            // AdressText
            // 
            AdressText.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            AdressText.Location = new Point(74, 495);
            AdressText.Name = "AdressText";
            AdressText.Size = new Size(189, 32);
            AdressText.TabIndex = 11;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            AddBtn.Location = new Point(107, 557);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(120, 62);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "Добавить";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // PhoneNumberNumeric
            // 
            PhoneNumberNumeric.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PhoneNumberNumeric.Location = new Point(107, 411);
            PhoneNumberNumeric.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            PhoneNumberNumeric.Minimum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            PhoneNumberNumeric.Name = "PhoneNumberNumeric";
            PhoneNumberNumeric.Size = new Size(131, 32);
            PhoneNumberNumeric.TabIndex = 14;
            PhoneNumberNumeric.Value = new decimal(new int[] { 1410065408, 2, 0, 0 });
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(11F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 731);
            Controls.Add(PhoneNumberNumeric);
            Controls.Add(AddBtn);
            Controls.Add(AdressText);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(EmailText);
            Controls.Add(label4);
            Controls.Add(PatronymicText);
            Controls.Add(label3);
            Controls.Add(NameText);
            Controls.Add(SurnameText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClientForm";
            Text = "Добавление клиентов";
            ((System.ComponentModel.ISupportInitialize)PhoneNumberNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox SurnameText;
        private TextBox NameText;
        private Label label3;
        private TextBox PatronymicText;
        private Label label4;
        private TextBox EmailText;
        private Label label5;
        private Label label6;
        private TextBox AdressText;
        private Button AddBtn;
        private NumericUpDown PhoneNumberNumeric;
    }
}