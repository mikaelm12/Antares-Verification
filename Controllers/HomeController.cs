using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using antares_ver.Models;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace antares_ver.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var assemblies = new List<string>
            {
                {typeof(object).GetTypeInfo().Assembly.Location},
                {typeof(Controller).GetTypeInfo().Assembly.Location},
                {typeof(LoggerFactory).GetTypeInfo().Assembly.Location},
                {typeof(IServiceCollection).GetTypeInfo().Assembly.Location}
            };

            ViewData["Message"] = assemblies;


            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
