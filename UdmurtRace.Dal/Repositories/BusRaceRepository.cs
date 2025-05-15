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
    public class BusRaceRepository : IBaseRepository<BusRace>
    {
        public bool Add(BusRace Item)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    db.BusRaces.Add(Item);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public BusRace? Get(int id)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    return db.BusRaces.FirstOrDefault(r => r.Id == id);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<BusRace> GetAll()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    return db.BusRaces.ToList();
                }
            }
            catch (Exception)
            {
                return new List<BusRace>();
            }
        }

        public bool Remove(int id)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    db.BusRaces.Where(x => x.Id == id).ExecuteDelete();
                    db.SaveChanges(); 
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(BusRace Item)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    db.BusRaces.Update(Item);
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
