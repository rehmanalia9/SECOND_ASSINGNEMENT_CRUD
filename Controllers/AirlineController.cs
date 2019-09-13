using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondAssingnment.Models;

namespace SecondAssingnment.Controllers
{
    public class AirlineController : Controller
    {
        private Airline_InformationContext ORM = null;
        public AirlineController(Airline_InformationContext _ORM)
        {
            ORM = _ORM;
        }

        [HttpGet]
        public IActionResult AddNewAirline()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewAirline(Airline AL)
        {
            try
            {
                ORM.Airline.AddAsync(AL);
                ORM.SaveChangesAsync();
                ViewBag.Message = AL.Name + "Airline Saved sucessfully";
                ViewBag.MessageType = "S";

            }
            catch(Exception ex)
            {

                ViewBag.Message = "Error please try again";
                ViewBag.MessageType = "E";
                
            }

            return View();
        }


        public IActionResult AllAirlines()
        {
            return View(ORM.Airline.ToList());
        }
        public IActionResult DeleteAirline(int id)
        {
            var Al= ORM.Airline.Find(id);
            ORM.Airline.Remove(Al);
            ORM.SaveChanges();

            return RedirectToAction("AllAirlines");
        }

        [HttpGet]
        public IActionResult EditAirline(int id)
        {
            var Al= ORM.Airline.Find(id);
            return View(Al);
        }

        [HttpPost]
        public IActionResult EditAirline(Airline Al)
        {
            ORM.Airline.Update(Al);
            ORM.SaveChanges();
            return RedirectToAction("AllAirlines");
        }

        public IActionResult ViewAirlineDetail(int id)
        {
            return View(ORM.Airline.Find(id));
        }
    }
}