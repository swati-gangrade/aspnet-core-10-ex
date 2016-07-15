using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_10_ex.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string frameworkVersion = "Not available";

            if (Environment.GetEnvironmentVariable("ASPNET_VERSION") != null)
                frameworkVersion = "Current application running on ASP.NET " + Environment.GetEnvironmentVariable("ASPNET_VERSION").ToString();

            ViewBag.FrameworkVersion = frameworkVersion;

            string environmentVariables = string.Empty;
            foreach (System.Collections.DictionaryEntry de in Environment.GetEnvironmentVariables())
                environmentVariables += string.Format("{0} = {1}\n", de.Key.ToString().Trim(), de.Value.ToString().Trim());

            ViewBag.EnvironmentVariables = environmentVariables;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
