using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace WebApp_FizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        [Display(Name = "FizzBuzz")]
        [Required(ErrorMessage = "Value has to be in range from 1 to 1000!")]
        [Range(1, 1000, ErrorMessage= "Value has to be in range from 1 to 1000!")]
        public int? input { get; set; }

        public string text { get; private set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            try
            {
                input = HttpContext.Session.GetInt32("inpu");
            }
            catch (Exception e)
            {
                // Ignore
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            //ModelState.TryGetValue("input", out input);
            HttpContext.Session.SetInt32("input", input.Value);
            //return RedirectToPage("./OstatnioWyszukiwane");
            return Page();

            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("SessionAddress",
                    JsonConvert.SerializeObject(input));
                return RedirectToPage("./OstatnioWyszukiwane");
            }
            return Page();
        }
    }
}
