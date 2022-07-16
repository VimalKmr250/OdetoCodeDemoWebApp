using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdetoCode.Data;
using OdeToCode.Food;

namespace OdetoCodeDemoWebApp.Pages.Resturant
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration configuration;
        private readonly IResturantData resturantData;

        public ListModel(IConfiguration configuration, IResturantData resturantData)
        {
            this.configuration = configuration;
            this.resturantData = resturantData;
        }

        public string Message { get; set; }
        public IEnumerable<Resturants> resturants{ get; set; }
        public void OnGet()
        {
            Message = configuration["Message"];

            resturants = resturantData.GetAll();

        }
    }
}
