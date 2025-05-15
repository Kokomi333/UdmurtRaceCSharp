using MySql.Data.MySqlClient;
using UdmurtRace.Domain;
using UdmurtRace.Dal.Repositories;

namespace lab3C_
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                IBaseRepository<BusRace> busRaceRepository = new BusRaceRepository();
                IBaseRepository<Client> clientRepository = new ClientRepository();
                IBaseRepository<Ticket> ticketRepository = new TicketRepository(); 

                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm(busRaceRepository, clientRepository, ticketRepository));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}