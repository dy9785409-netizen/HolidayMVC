using HolidayApp.Data;
using HolidayApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayApp.Controllers
{
    public class HolidayController : Controller
    {
        private readonly AppDbContext _context;

        public HolidayController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.EditHoliday = new Holiday();

            var holidays = _context.Holidays.ToList();

            return View(holidays);
        }

        [HttpPost]
        public IActionResult Save(Holiday holiday)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.EditHoliday = holiday;

                return View(
                    "Index",
                    _context.Holidays.ToList());
            }

            // UPDATE
            if (holiday.Id > 0)
            {
                _context.Holidays.Update(holiday);
            }
            // INSERT
            else
            {
                _context.Holidays.Add(holiday);
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var holiday =
                _context.Holidays
                        .FirstOrDefault(x => x.Id == id);

            ViewBag.EditHoliday = holiday;

            return View(
                "Index",
                _context.Holidays.ToList());
        }

        public IActionResult Delete(int id)
        {
            var holiday =
                _context.Holidays
                        .FirstOrDefault(x => x.Id == id);

            if (holiday != null)
            {
                _context.Holidays.Remove(holiday);

                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}