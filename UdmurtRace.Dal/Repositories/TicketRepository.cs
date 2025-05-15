using lab3C_;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdmurtRace.Domain;

namespace UdmurtRace.Dal.Repositories
{
    public class TicketRepository : IBaseRepository<Ticket>
    {
        public bool Add(Ticket Item)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    db.Tickets.Add(Item);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Ticket? Get(int id)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    return db.Tickets
                        .Include(x => x.ClientModel)
                        .Include(x => x.BusRaceModel)
                        .FirstOrDefault(t => t.Id == id);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Ticket> GetAll()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    return db.Tickets
                        .Include(x => x.ClientModel)
                        .Include (x => x.BusRaceModel)
                        .ToList();
                }
            }
            catch (Exception)
            {
                return new List<Ticket>();
            }
        }

        public bool Remove(int id)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    db.Tickets.Where(t => t.Id == id);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Ticket Item)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    db.Tickets.Update(Item);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
