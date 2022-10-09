using EntityFramework.Lab.Entities;
using EntityFramework.Lab.Logic.AMBLogics;
using EntityFramework.Lab.MVC.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace EntityFramework.Lab.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic sLogic = new ShippersLogic();

        [HttpGet]
        public ActionResult Index()
        {
            List<Shippers> shippers = sLogic.GetAll();
            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID,
                NameOfCompany = s.CompanyName,
                PhoneNumber = s.Phone

            }).ToList();
            return View(shippersView);
        }

        [HttpGet]
        public ActionResult InsertUpdate(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                try
                {
                    Shippers shipper = sLogic.Search(id);
                    ShippersView shippersView = new ShippersView
                    {
                        Id = shipper.ShipperID,
                        NameOfCompany = shipper.CompanyName,
                        PhoneNumber = shipper.Phone
                    };
                    return View(shippersView);
                }
                catch (Exception)
                {
                    return RedirectToAction("Index", "Error");
                }
            }
        }

        [HttpPost]
        public ActionResult InsertUpdate(ShippersView shippersView)
        {
            Shippers entityShipper = new Shippers
            {
                ShipperID = shippersView.Id,
                CompanyName = shippersView.NameOfCompany,
                Phone = shippersView.PhoneNumber,
            };

            if (!ModelState.IsValid)
            {
                return View(shippersView);
            }

            if (entityShipper.ShipperID == 0)
                sLogic.Add(entityShipper);
            else
            {
                try
                {
                    sLogic.Update(entityShipper);
                }
                catch (Exception)
                {
                    return View("Error");
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            try
            {
                sLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}
