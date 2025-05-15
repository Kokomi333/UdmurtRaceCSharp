namespace lab3C_
{
    partial class MainForm
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
            Button DeleteBusRaceBtn;
            BusRaceDatagrid = new DataGridView();
            ClientDatagrid = new DataGridView();
            AddClientBtn = new Button();
            UpdateClientBtn = new Button();
            DeleteClientBtn = new Button();
            TicketDatagrid = new DataGridView();
            AddBusRaceBtn = new Button();
            UpdateBusRaceBtn = new Button();
            DeleteTicketBtn = new Button();
            UpdateTicketBtn = new Button();
            AddTicketBtn = new Button();
            DeleteBusRaceBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)BusRaceDatagrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClientDatagrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TicketDatagrid).BeginInit();
            SuspendLayout();
            // 
            // DeleteBusRaceBtn
            // 
            DeleteBusRaceBtn.BackColor = Color.FromArgb(255, 128, 128);
            DeleteBusRaceBtn.FlatAppearance.BorderColor = Color.Black;
            DeleteBusRaceBtn.FlatAppearance.BorderSize = 6;
            DeleteBusRaceBtn.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            DeleteBusRaceBtn.Location = new Point(623, 446);
            DeleteBusRaceBtn.Name = "DeleteBusRaceBtn";
            DeleteBusRaceBtn.Size = new Size(272, 50);
            DeleteBusRaceBtn.TabIndex = 4;
            DeleteBusRaceBtn.Text = "Удалить рейс";
            DeleteBusRaceBtn.UseVisualStyleBackColor = false;
            DeleteBusRaceBtn.Click += DeleteBusRaceBtn_Click;
            // 
            // BusRaceDatagrid
            // 
            BusRaceDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BusRaceDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BusRaceDatagrid.Location = new Point(29, 37);
            BusRaceDatagrid.Name = "BusRaceDatagrid";
            BusRaceDatagrid.Size = new Size(866, 402);
            BusRaceDatagrid.TabIndex = 0;
            BusRaceDatagrid.CellContentClick += BusRaceDatagrid_CellContentClick;
            // 
            // ClientDatagrid
            // 
            ClientDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClientDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientDatagrid.Location = new Point(901, 37);
            ClientDatagrid.Name = "ClientDatagrid";
            ClientDatagrid.Size = new Size(866, 402);
            ClientDatagrid.TabIndex = 1;
            ClientDatagrid.CellContentClick += ClientDatagrid_CellContentClick;
            // 
            // AddClientBtn
            // 
            AddClientBtn.BackColor = Color.FromArgb(128, 255, 128);
            AddClientBtn.FlatAppearance.BorderColor = Color.Black;
            AddClientBtn.FlatAppearance.BorderSize = 6;
            AddClientBtn.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            AddClientBtn.Location = new Point(1495, 445);
            AddClientBtn.Name = "AddClientBtn";
            AddClientBtn.Size = new Size(272, 50);
            AddClientBtn.TabIndex = 7;
            AddClientBtn.Text = "Добавить клиента";
            AddClientBtn.UseVisualStyleBackColor = false;
            AddClientBtn.Click += AddClientBtn_Click;
            // 
            // UpdateClientBtn
            // 
            UpdateClientBtn.BackColor = Color.FromArgb(255, 255, 128);
            UpdateClientBtn.FlatAppearance.BorderColor = Color.Black;
            UpdateClientBtn.FlatAppearance.BorderSize = 6;
            UpdateClientBtn.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            UpdateClientBtn.Location = new Point(1179, 445);
            UpdateClientBtn.Name = "UpdateClientBtn";
            UpdateClientBtn.Size = new Size(310, 50);
            UpdateClientBtn.TabIndex = 6;
            UpdateClientBtn.Text = "Изменить клиента";
            UpdateClientBtn.UseVisualStyleBackColor = false;
            UpdateClientBtn.Click += UpdateClientBtn_Click;
            // 
            // DeleteClientBtn
            // 
            DeleteClientBtn.BackColor = Color.FromArgb(255, 128, 128);
            DeleteClientBtn.FlatAppearance.BorderColor = Color.Black;
            DeleteClientBtn.FlatAppearance.BorderSize = 6;
            DeleteClientBtn.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            DeleteClientBtn.Location = new Point(901, 445);
            DeleteClientBtn.Name = "DeleteClientBtn";
            DeleteClientBtn.Size = new Size(272, 50);
            DeleteClientBtn.TabIndex = 5;
            DeleteClientBtn.Text = "Удалить клиента";
            DeleteClientBtn.UseVisualStyleBackColor = false;
            DeleteClientBtn.Click += DeleteClientBtn_Click;
            // 
            // TicketDatagrid
            // 
            TicketDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TicketDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TicketDatagrid.Location = new Point(445, 502);
            TicketDatagrid.Name = "TicketDatagrid";
            TicketDatagrid.Size = new Size(866, 380);
            TicketDatagrid.TabIndex = 8;
            TicketDatagrid.CellContentClick += TicketDatagrid_CellContentClick;
            // 
            // AddBusRaceBtn
            // 
            AddBusRaceBtn.BackColor = Color.FromArgb(128, 255, 128);
            AddBusRaceBtn.FlatAppearance.BorderColor = Color.Black;
            AddBusRaceBtn.FlatAppearance.BorderSize = 6;
            AddBusRaceBtn.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            AddBusRaceBtn.Location = new Point(29, 445);
            AddBusRaceBtn.Name = "AddBusRaceBtn";
            AddBusRaceBtn.Size = new Size(272, 50);
            AddBusRaceBtn.TabIndex = 2;
            AddBusRaceBtn.Text = "Добавить рейс";
            AddBusRaceBtn.UseVisualStyleBackColor = false;
            AddBusRaceBtn.Click += AddBusRaceBtn_Click;
            // 
            // UpdateBusRaceBtn
            // 
            UpdateBusRaceBtn.BackColor = Color.FromArgb(255, 255, 128);
            UpdateBusRaceBtn.FlatAppearance.BorderColor = Color.Black;
            UpdateBusRaceBtn.FlatAppearance.BorderSize = 6;
            UpdateBusRaceBtn.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            UpdateBusRaceBtn.Location = new Point(307, 445);
            UpdateBusRaceBtn.Name = "UpdateBusRaceBtn";
            UpdateBusRaceBtn.Size = new Size(310, 50);
            UpdateBusRaceBtn.TabIndex = 3;
            UpdateBusRaceBtn.Text = "Изменить рейс";
            UpdateBusRaceBtn.UseVisualStyleBackColor = false;
            UpdateBusRaceBtn.Click += UpdateBusRaceBtn_Click;
            // 
            // DeleteTicketBtn
            // 
            DeleteTicketBtn.BackColor = Color.FromArgb(255, 128, 128);
            DeleteTicketBtn.FlatAppearance.BorderColor = Color.Black;
            DeleteTicketBtn.FlatAppearance.BorderSize = 6;
            DeleteTicketBtn.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            DeleteTicketBtn.Location = new Point(1039, 888);
            DeleteTicketBtn.Name = "DeleteTicketBtn";
            DeleteTicketBtn.Size = new Size(272, 50);
            DeleteTicketBtn.TabIndex = 11;
            DeleteTicketBtn.Text = "Удалить билет";
            DeleteTicketBtn.UseVisualStyleBackColor = false;
            DeleteTicketBtn.Click += DeleteTicketBtn_Click;
            // 
            // UpdateTicketBtn
            // 
            UpdateTicketBtn.BackColor = Color.FromArgb(255, 255, 128);
            UpdateTicketBtn.FlatAppearance.BorderColor = Color.Black;
            UpdateTicketBtn.FlatAppearance.BorderSize = 6;
            UpdateTicketBtn.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            UpdateTicketBtn.Location = new Point(723, 888);
            UpdateTicketBtn.Name = "UpdateTicketBtn";
            UpdateTicketBtn.Size = new Size(310, 50);
            UpdateTicketBtn.TabIndex = 10;
            UpdateTicketBtn.Text = "Изменить билет";
            UpdateTicketBtn.UseVisualStyleBackColor = false;
            UpdateTicketBtn.Click += UpdateTicketBtn_Click;
            // 
            // AddTicketBtn
            // 
            AddTicketBtn.BackColor = Color.FromArgb(128, 255, 128);
            AddTicketBtn.FlatAppearance.BorderColor = Color.Black;
            AddTicketBtn.FlatAppearance.BorderSize = 6;
            AddTicketBtn.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            AddTicketBtn.Location = new Point(445, 888);
            AddTicketBtn.Name = "AddTicketBtn";
            AddTicketBtn.Size = new Size(272, 50);
            AddTicketBtn.TabIndex = 9;
            AddTicketBtn.Text = "Добавить билет";
            AddTicketBtn.UseVisualStyleBackColor = false;
            AddTicketBtn.Click += AddTicketBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1792, 944);
            Controls.Add(AddBusRaceBtn);
            Controls.Add(UpdateBusRaceBtn);
            Controls.Add(DeleteBusRaceBtn);
            Controls.Add(DeleteTicketBtn);
            Controls.Add(UpdateTicketBtn);
            Controls.Add(AddTicketBtn);
            Controls.Add(TicketDatagrid);
            Controls.Add(AddClientBtn);
            Controls.Add(UpdateClientBtn);
            Controls.Add(DeleteClientBtn);
            Controls.Add(ClientDatagrid);
            Controls.Add(BusRaceDatagrid);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Основная форма";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)BusRaceDatagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClientDatagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)TicketDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView BusRaceDatagrid;
        private DataGridView ClientDatagrid;
        private Button AddBusRaceBtn;
        private Button UpdateBusRaceBtn;
        private Button DeleteBusRaceBtn;
        private Button AddClientBtn;
        private Button UpdateClientBtn;
        private Button DeleteClientBtn;
        private DataGridView TicketDatagrid;
        private Button DeleteTicketBtn;
        private Button UpdateTicketBtn;
        private Button AddTicketBtn;
    }
}