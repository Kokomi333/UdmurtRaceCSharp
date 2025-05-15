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
    public partial class TicketForm : Form
    {
        private readonly IBaseRepository<Ticket> _ticketRepository;
        private readonly IBaseRepository<Client> _clientRepository;
        private readonly IBaseRepository<BusRace> _busRaceRepository;
        public event Action? UpdateHandler;
        private int Id;
        public TicketForm(IBaseRepository<Ticket> ticketRepository, IBaseRepository<Client> clientRepository, IBaseRepository<BusRace> busRaceRepository)
        {
            InitializeComponent();
            _ticketRepository = ticketRepository;
            _clientRepository = clientRepository;
            _busRaceRepository = busRaceRepository;
            Id = 0;
            foreach (var busRace in _busRaceRepository.GetAll())
            {
                IdBusRaceComboBox.Items.Add(busRace.Id);
            }
            foreach (var client in _clientRepository.GetAll())
            {
                IdClientComboBox.Items.Add(client.Id);
            }
        }

        public TicketForm(IBaseRepository<Ticket> ticketRepository, IBaseRepository<Client> clientRepository, IBaseRepository<BusRace> busRaceRepository, int id)
        {
            InitializeComponent();
            _ticketRepository = ticketRepository;
            _clientRepository = clientRepository;
            _busRaceRepository = busRaceRepository;
            Id = id;
            LoadTicket();
            foreach (var busRace in _busRaceRepository.GetAll())
            {
                IdBusRaceComboBox.Items.Add(busRace.Id);
            }
            foreach (var client in _clientRepository.GetAll())
            {
                IdClientComboBox.Items.Add(client.Id);
            }
        }

        private void IdBusRaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int IdBusRace = Convert.ToInt32(IdBusRaceComboBox.SelectedItem);
                BusRace busRace = _busRaceRepository.Get(IdBusRace);
                if (busRace != null)
                {
                    DateDepartationPicker.Value = busRace.DepartureDateTime;
                    TimeDepartationPicker.Value = busRace.DepartureDateTime;
                    TicketCostNumeric.Value = Convert.ToDecimal(busRace.TicketCost);
                }
            }
            catch (Exception)
            {

            }
        }

        private void IdClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int IdClient = Convert.ToInt32(IdClientComboBox.SelectedItem);
                Client client = _clientRepository.Get(IdClient);
                if (client != null)
                {
                    NameClientTextBox.Text = client.Name;
                    AdresClientText.Text = client.Address;
                    PhoneNumberNumeric.Value = Convert.ToDecimal(client.PhoneNumber);
                }
            }
            catch (Exception)
            {

            }
        }

        private void LoadTicket()
        {
            Ticket ticket = _ticketRepository.Get(Id);
            BusRace busRace = ticket.BusRaceModel;
            Client client = ticket.ClientModel;
            this.Text = "Обновление билета";
            AddBtn.Text = "Обновить";
            IdBusRaceComboBox.Text = $"{busRace.Id}";
            DateDepartationPicker.Text = busRace.DepartureDateTime.ToShortDateString();
            TimeDepartationPicker.Text = busRace.DepartureDateTime.ToShortTimeString();
            TicketCostNumeric.Value = Convert.ToDecimal(busRace.TicketCost);
            IdClientComboBox.Text = $"{client.Id}";
            NameClientTextBox.Text = client.Name;
            AdresClientText.Text = client.Address;
            PhoneNumberNumeric.Value = Convert.ToDecimal(client.PhoneNumber);
            StatusText.Text = ticket.Status;
            DescriptionText.Text = ticket.Notes;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (StatusText.Text == "")
                {
                    MessageBox.Show("Статус не может быть пустым!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DescriptionText.Text == "")
                {
                    MessageBox.Show("Примечание не может быть пустым!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Ticket ticket = new Ticket()
                {
                    BusRaceModel = _busRaceRepository.Get(Convert.ToInt32(IdBusRaceComboBox.Text)),
                    ClientModel = _clientRepository.Get(Convert.ToInt32(IdClientComboBox.Text)),
                    Status = StatusText.Text,
                    Notes = DescriptionText.Text
                };
                ticket.IdBusRace = ticket.BusRaceModel.Id;
                ticket.IdClient = ticket.ClientModel.Id;
                if (Id == 0)
                {
                    _ticketRepository.Add(ticket);
                    MessageBox.Show("Билет успешно добавлен");
                }
                else
                {
                    ticket.Id = Id;
                    _ticketRepository.Update(ticket);
                    MessageBox.Show("Билет успешно обновлен");
                }
                UpdateHandler?.Invoke();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Что то пошло не так!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
