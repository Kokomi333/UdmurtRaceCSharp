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

    public class ClientRepository : IBaseRepository<Client>
    {
        public bool Add(Client Item)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    db.Clients.Add(Item);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Client? Get(int id)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    return db.Clients.FirstOrDefault(c => c.Id == id);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Client> GetAll()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    return db.Clients.ToList();
                }
            }
            catch (Exception)
            {
                return new List<Client>();
            }
        }

        public bool Remove(int id)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    db.Clients.Where(x => x.Id == id).ExecuteDelete();
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Client Item)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    db.Clients.Update(Item);
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
