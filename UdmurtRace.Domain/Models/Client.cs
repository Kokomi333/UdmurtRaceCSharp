using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdmurtRace.Domain
{
    public class Client
    {
        public int Id { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public List<Ticket>? Tickets { get; set; } = new List<Ticket>();

        public Client()
        {
            
        }
        public Client(int id, string? surname, string? name, string? patronymic, string? email, string? phoneNumber, string? adress)
        {
            Id = id;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = adress;
        }
        public Client(string? surname, string? name, string? patronymic, string? email, string? phoneNumber, string? adress)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = adress;
        }
    }
}
