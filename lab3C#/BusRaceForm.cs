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
    public partial class BusRaceForm : Form
    {
        private readonly IBaseRepository<BusRace> _busRaceRepository;
        public event Action? UpdateHandler;
        private int Id;
        public BusRaceForm(IBaseRepository<BusRace> busRaceRepository) // Добавление
        {
            InitializeComponent();
            _busRaceRepository = busRaceRepository;
            Id = 0;
        }

        public BusRaceForm(IBaseRepository<BusRace> busRaceRepository, int id) // Изменение
        {
            InitializeComponent();
            _busRaceRepository = busRaceRepository;
            Id = id;
            LoadBusRaces();
        }

        private void LoadBusRaces() // Подставка значений для изменения
        {
            BusRace busRace = _busRaceRepository.Get(Id);
            this.Text = "Обновление рейса";
            AddBtn.Text = "Обновить";
            DateRacePicker.Text = busRace.DepartureDateTime.ToShortDateString();
            TimeRacePicker.Text = busRace.DepartureDateTime.ToShortTimeString();
            DestinationTextArea.Text = busRace.Destination;
            TicketCostNumeric.Value = Convert.ToDecimal(busRace.TicketCost);
            NumberOfSeatsNumeric.Value = busRace.NumberOfSeats;
            DescriptionTextArea.Text = busRace.Description;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DestinationTextArea.Text == "")
                {
                    MessageBox.Show("Пункт назначения не может быть пустым!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DescriptionTextArea.Text == "")
                {
                    MessageBox.Show("Описание рейса не может быть пустым!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BusRace busRace = new()
                {
                    DepartureDateTime = (DateOnly.FromDateTime(DateRacePicker.Value)).ToDateTime(TimeOnly.FromDateTime(TimeRacePicker.Value)),
                    Destination = DestinationTextArea.Text,
                    TicketCost = Convert.ToDouble(TicketCostNumeric.Text),
                    NumberOfSeats = Convert.ToInt32(NumberOfSeatsNumeric.Value),
                    Description = DescriptionTextArea.Text
                };

                if (Id == 0)
                {
                    _busRaceRepository.Add(busRace);
                    MessageBox.Show("Автобусный рейс успешно добавлен!");
                }
                else
                {
                    busRace.Id = Id;
                    _busRaceRepository.Update(busRace);
                    MessageBox.Show("Автобусный рейс успешно обновлен!");
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
