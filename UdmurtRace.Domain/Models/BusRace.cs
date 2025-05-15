using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdmurtRace.Domain
{
    public class BusRace
    {
        public int Id { get; set; } // Номер рейса
        public DateTime DepartureDateTime { get; set; } // Дата и время отправления
        public string? Destination {  get; set; } // Пункт назначения
        public double TicketCost { get; set; } // Стоимость билета
        public int NumberOfSeats { get; set; } // Количество мест
        public string? Description { get; set; } // Описание рейса
        public List<Ticket>? Tickets { get; set; } = new List<Ticket>();
        public BusRace()
        {
            
        }
        public BusRace(int id, DateTime departureDateTime, string? destination, double ticketCost, int numberOfSeats, string? description)
        {
            Id = id;
            DepartureDateTime = departureDateTime;
            Destination = destination;
            TicketCost = ticketCost;
            NumberOfSeats = numberOfSeats;
            Description = description;
        }
        public BusRace(DateTime departureDateTime, string? destination, double ticketCost, int numberOfSeats, string? description)
        {
            DepartureDateTime = departureDateTime;
            Destination = destination;
            TicketCost = ticketCost;
            NumberOfSeats = numberOfSeats;
            Description = description;
        }
    }
}
