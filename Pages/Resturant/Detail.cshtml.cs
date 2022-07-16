using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdetoCode.Data;
using OdeToCode.Food;

namespace OdetoCodeDemoWebApp.Pages.Resturant
{
    public class DetailModel : PageModel
    {
        private readonly IResturantData resturantData;
        public Resturants Resturant { get; set; }

        public DetailModel(IResturantData resturantData )
        {
            this.resturantData = resturantData;
        }


        public IActionResult OnGet(string resturantID)
        {
            Resturant = resturantData.GetResturantByID(resturantID);

            if (Resturant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
