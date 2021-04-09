using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Extensions.Logging;
using WebApp_FizzBuzz.Data;
using WebApp_FizzBuzz.Models;

namespace WebApp_FizzBuzz.Pages
{
    public class Ostatnio_szukaneModel : PageModel
    {
        public List<FizzBuzzEntry> entriesList { get; private set; }

        public readonly ILogger<Ostatnio_szukaneModel> _logger;
        readonly FizzBuzzContext _context;

        public const int entriesListLenght = 10;

        public Ostatnio_szukaneModel(ILogger<Ostatnio_szukaneModel> logger, FizzBuzzContext context)
        {
            _logger = logger;
            _context = context;
        }


        public void OnGet()
        {
            entriesList = _context.FizzBuzzEntries.OrderByDescending(a => a.date).Take(entriesListLenght).ToList();
        }

        public IActionResult OnPostDeleteEntry()
        {
            _logger.LogInformation($"It takes too loooong... now?");
            return Page();
            //string message = "Welcome";
            //return new JsonResult { Data = message, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public IActionResult OnPostDeleteEntry(string value)
        {
            _logger.LogInformation($"It takes too loooong... {value}");
            return Page();
            //string message = "Welcome";
            //return new JsonResult { Data = message, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
