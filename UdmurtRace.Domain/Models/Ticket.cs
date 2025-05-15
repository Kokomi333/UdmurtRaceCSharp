using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdmurtRace.Domain
{
    public class Ticket
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public Client? ClientModel;
        public int IdBusRace {  get; set; }
        public BusRace? BusRaceModel;
        public string? Status { get; set; }
        public string? Notes { get; set; }
        public Ticket()
        {
            
        }
        public Ticket(int id, Client client, BusRace busRace, string? status, string? notes)
        {
            Id = id;
            IdClient = client.Id;
            IdBusRace = busRace.Id;
            ClientModel = client;
            BusRaceModel = busRace;
            Status = status;
            Notes = notes;
        }
        public Ticket(Client client, BusRace busRace, string? status, string? notes)
        {
            IdClient = client.Id;
            IdBusRace = busRace.Id;
            ClientModel = client;
            BusRaceModel = busRace;
            Status = status;
            Notes = notes;
        }
    }
}
