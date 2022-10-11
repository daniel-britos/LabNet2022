using EntityFramework.Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.Logic.Logic
{
    public class ShippersLogic : BaseLogic
    {
        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }
        public void Add(Shippers shipper)
        {
            try
            {
                _context.Shippers.Add(shipper);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }
        }
        public void Update(Shippers shipper)
        {
            try
            {
                var shipperUpdate = _context.Shippers.Find(shipper.ShipperID);
                shipperUpdate.Phone = shipper.Phone;
                shipperUpdate.CompanyName = shipper.CompanyName;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var shipperDelete = _context.Shippers.Find(id);

                _context.Shippers.Remove(shipperDelete);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }
        }
        public Shippers Search(int? id)
        {
            return _context.Shippers.Find(id);            
        }
        public List<Shippers> FindShippers(int id)
        {
            var shippers = _context.Shippers.ToList().Take(id);

            return shippers.ToList();
        }
    }
}
