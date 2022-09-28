﻿using EntityFramework.Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.Logic.AMBLogics
{
    public class ShippersLogic : BaseLogic
    {
        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }
        public void Add(Shippers shipper)
        {
            _context.Shippers.Add(shipper);

            _context.SaveChanges();
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
            }
        }
        public void Delete(int id)
        {
            var shipperDelete = _context.Shippers.Find(id);

            _context.Shippers.Remove(shipperDelete);

            _context.SaveChanges();
        }
        public void Search(int id)
        {
            var shipper = _context.Shippers.Find(id);
            Console.WriteLine($"Company name: {shipper.CompanyName}, Phone: {shipper.Phone}");
        }
    }
}
