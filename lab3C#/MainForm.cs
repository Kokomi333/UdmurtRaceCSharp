using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UdmurtRace.Domain;

namespace lab3C_
{
    public partial class MainForm : Form
    {
        private readonly IBaseRepository<BusRace> _busRaceRepository;
        private readonly IBaseRepository<Client> _clientRepository;
        private readonly IBaseRepository<Ticket> _ticketRepository;
        public MainForm(IBaseRepository<BusRace> busRaceRepository, IBaseRepository<Client> clientRepository, IBaseRepository<Ticket> ticketRepository)
        {
            InitializeComponent();
            _busRaceRepository = busRaceRepository;
            _clientRepository = clientRepository;
            _ticketRepository = ticketRepository;
            LoadAll();
            ChangeColumnNames();
        }

        private void ChangeColumnNames()
        {
            // Автобусные колонны
            BusRaceDatagrid.Columns["DepartureDateTime"].HeaderText = "Отправка";
            BusRaceDatagrid.Columns["Destination"].HeaderText = "Пункт назначения";
            BusRaceDatagrid.Columns["TicketCost"].HeaderText = "Стоимость";
            BusRaceDatagrid.Columns["NumberOfSeats"].HeaderText = "Места";
            BusRaceDatagrid.Columns["Description"].HeaderText = "Описание";

            ClientDatagrid.Columns["Surname"].HeaderText = "Фамилия";
            ClientDatagrid.Columns["Name"].HeaderText = "Имя";
            ClientDatagrid.Columns["Patronymic"].HeaderText = "Отчество";
            ClientDatagrid.Columns["Email"].HeaderText = "Почта";
            ClientDatagrid.Columns["PhoneNumber"].HeaderText = "Телефон";
            ClientDatagrid.Columns["Address"].HeaderText = "Адресс";

            TicketDatagrid.Columns["IdClient"].HeaderText = "Id клиента";
            TicketDatagrid.Columns["IdBusRace"].HeaderText = "Id рейса";
            TicketDatagrid.Columns["Status"].HeaderText = "Статус";
            TicketDatagrid.Columns["Notes"].HeaderText = "Дополнительно";
        }

        public void LoadAll()
        {
            try
            {
                var BusRaces = _busRaceRepository.GetAll();
                BusRaceDatagrid.DataSource = null;
                BusRaceDatagrid.DataSource = BusRaces;
            }
            catch (Exception) { }

            try
            {
                var Clients = _clientRepository.GetAll();
                ClientDatagrid.DataSource = null;
                ClientDatagrid.DataSource = Clients;
            }
            catch (Exception) { }

            try
            {
                var Tickets = _ticketRepository.GetAll();
                TicketDatagrid.DataSource = null;
                TicketDatagrid.DataSource = Tickets;
            }
            catch (Exception) { }
        }

        // Рейсы

        private void AddBusRaceBtn_Click(object sender, EventArgs e)
        {
            BusRaceForm form = new BusRaceForm(_busRaceRepository);
            form.UpdateHandler += LoadAll;
            form.Show();
        }

        private void UpdateBusRaceBtn_Click(object sender, EventArgs e)
        {
            if (BusRaceDatagrid.SelectedRows.Count == 1)
            {
                // Получаем выделенный ряд в переменную
                var selectedRow = BusRaceDatagrid.SelectedRows[0];
                // Достаем id
                var BusRaceId = selectedRow.Cells["Id"].Value;
                if (BusRaceId != null && int.TryParse(BusRaceId.ToString(), out int id))
                {
                    try
                    {
                        BusRaceForm form = new BusRaceForm(_busRaceRepository, id);
                        form.UpdateHandler += LoadAll;
                        form.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteBusRaceBtn_Click(object sender, EventArgs e)
        {
            if (BusRaceDatagrid.SelectedRows.Count == 1)
            {
                // Получаем выделенный ряд в переменную
                var selectedRow = BusRaceDatagrid.SelectedRows[0];
                // Достаем id
                var BusRaceId = selectedRow.Cells["Id"].Value;
                // Валидируем id на всякий случай
                if (BusRaceId != null && int.TryParse(BusRaceId.ToString(), out int id))
                {
                    try
                    {
                        var Tickets = _ticketRepository.GetAll();
                        if (Tickets.FindIndex(x => x.IdBusRace == id) != -1)
                        {
                            MessageBox.Show("Такой рейс уже есть в билетах!");
                            return;
                        }
                        // Вызываем метод удаления пользователя по id
                        _busRaceRepository.Remove(id);

                        // Обновляем таблицу после удаления
                        LoadAll();
                        MessageBox.Show("Рейс успешно удален.");
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Клиенты

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm(_clientRepository);
            form.UpdateHandler += LoadAll;
            form.Show();
        }

        private void UpdateClientBtn_Click(object sender, EventArgs e)
        {
            if (ClientDatagrid.SelectedRows.Count == 1)
            {
                // Получаем выделенный ряд в переменную
                var selectedRow = ClientDatagrid.SelectedRows[0];
                // Достаем id
                var ClientId = selectedRow.Cells["Id"].Value;
                if (ClientId != null && int.TryParse(ClientId.ToString(), out int id))
                {
                    try
                    {
                        ClientForm form = new ClientForm(_clientRepository, id);
                        form.UpdateHandler += LoadAll;
                        form.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void DeleteClientBtn_Click(object sender, EventArgs e)
        {
            if (ClientDatagrid.SelectedRows.Count == 1)
            {
                // Получаем выделенный ряд в переменную
                var selectedRow = ClientDatagrid.SelectedRows[0];
                // Достаем id
                var ClientId = selectedRow.Cells["Id"].Value;
                // Валидируем id на всякий случай
                if (ClientId != null && int.TryParse(ClientId.ToString(), out int id))
                {
                    try
                    {
                        var Tickets = _ticketRepository.GetAll();
                        if (Tickets.FindIndex(x => x.IdClient == id) != -1)
                        {
                            MessageBox.Show("Такой клиент уже купил билет!");
                            return;
                        }
                        // Вызываем метод удаления пользователя по id
                        _clientRepository.Remove(id);

                        // Обновляем таблицу после удаления
                        LoadAll();
                        MessageBox.Show("Клиент успешно удален.");
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Билеты

        private void AddTicketBtn_Click(object sender, EventArgs e)
        {
            TicketForm form = new TicketForm(_ticketRepository, _clientRepository, _busRaceRepository);
            form.UpdateHandler += LoadAll;
            form.Show();
        }

        private void UpdateTicketBtn_Click(object sender, EventArgs e)
        {
            if (TicketDatagrid.SelectedRows.Count == 1)
            {
                // Получаем выделенный ряд в переменную
                var selectedRow = TicketDatagrid.SelectedRows[0];
                // Достаем id
                var TicketId = selectedRow.Cells["Id"].Value;
                if (TicketId != null && int.TryParse(TicketId.ToString(), out int id))
                {
                    try
                    {
                        TicketForm form = new TicketForm(_ticketRepository, _clientRepository, _busRaceRepository, id);
                        form.UpdateHandler += LoadAll;
                        form.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteTicketBtn_Click(object sender, EventArgs e)
        {
            if (TicketDatagrid.SelectedRows.Count == 1)
            {
                // Получаем выделенный ряд в переменную
                var selectedRow = TicketDatagrid.SelectedRows[0];
                // Достаем id
                var TicketId = selectedRow.Cells["Id"].Value;
                // Валидируем id на всякий случай
                if (TicketId != null && int.TryParse(TicketId.ToString(), out int id))
                {
                    try
                    {
                        // Вызываем метод удаления пользователя по id
                        _ticketRepository.Remove(id);

                        // Обновляем таблицу после удаления
                        LoadAll();
                        MessageBox.Show("Билет успешно удален.");
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BusRaceDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BusRaceDatagrid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void ClientDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClientDatagrid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void TicketDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TicketDatagrid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

