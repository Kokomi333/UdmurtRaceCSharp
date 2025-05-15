using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using UdmurtRace.Domain;

namespace lab3C_
{
    public partial class ClientForm : Form
    {
        private readonly IBaseRepository<Client> _clientRepository;
        public event Action? UpdateHandler;
        private int Id;
        public ClientForm(IBaseRepository<Client> clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            Id = 0;
        }
        public ClientForm(IBaseRepository<Client> clientRepository, int id)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            Id = id;
            LoadClients(Id);
        }

        private void LoadClients(int Id)
        {
            Client client = _clientRepository.Get(Id);
            this.Text = "Обновление клиента";
            AddBtn.Text = "Обновить";
            SurnameText.Text = client.Surname;
            NameText.Text = client.Name;
            PatronymicText.Text = client.Patronymic;
            EmailText.Text = client.Email;
            PhoneNumberNumeric.Text = client.PhoneNumber;
            AdressText.Text = client.Address;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (SurnameText.Text == "")
            {
                MessageBox.Show("Фамилия не может быть пустым!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NameText.Text == "")
            {
                MessageBox.Show("Имя не может быть пустым!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PatronymicText.Text == "")
            {
                MessageBox.Show("Отчество не может быть пустым!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EmailText.Text == "")
            {
                MessageBox.Show("Почта не может быть пустым!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(EmailText.Text, EmailPattern))
            {
                MessageBox.Show("Почта введена неправильно!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AdressText.Text == "")
            {
                MessageBox.Show("Адрес не может быть пустым!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Client client = new()
                {
                    Surname = SurnameText.Text,
                    Name = NameText.Text,
                    Patronymic = PatronymicText.Text,
                    Email = EmailText.Text,
                    PhoneNumber = PhoneNumberNumeric.Text,
                    Address = AdressText.Text,
                };
                if (Id == 0)
                {
                    _clientRepository.Add(client);
                    MessageBox.Show("Клиент успешно добавлен!");
                }
                else
                {
                    client.Id = Id;
                    _clientRepository.Update(client);
                    MessageBox.Show("Клиент успешно обновлен!");
                }
                UpdateHandler?.Invoke();
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
