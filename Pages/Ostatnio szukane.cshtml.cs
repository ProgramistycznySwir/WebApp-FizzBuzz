using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Extensions.Logging;
using WebApp_FizzBuzz.Data;

namespace WebApp_FizzBuzz.Pages
{
    public class Ostatnio_szukaneModel : PageModel
    {
        public string entriesList_string { get; set; }

        readonly ILogger<Ostatnio_szukaneModel> _logger;
        readonly FizzBuzzContext _context;

        public const int entriesListLenght = 10;

        public Ostatnio_szukaneModel(ILogger<Ostatnio_szukaneModel> logger, FizzBuzzContext context)
        {
            _logger = logger;
            _context = context;
        }


        public void OnGet()
        {
            var entriesList = _context.FizzBuzzEntries.OrderByDescending(a => a.date).Take(entriesListLenght).ToList();
            if (entriesList.Count is 0)
            {
                entriesList_string = "No entries in database... YET!";
                return;
            }

            entriesList_string = string.Join("\n",
                entriesList
                );
        }
    }
}
