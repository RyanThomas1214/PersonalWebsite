using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Models;

namespace PersonalWebsite.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		

		public IActionResult About()
		{
			ViewData["Message"] = "Blog page.";

			return View();
		}

		[HttpGet]
		public IActionResult FormSuccess(Person person)
		{

			return View(person);
		}


		[HttpGet]
		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		[HttpPost]
		public IActionResult SubmitForm(Person person)
		{
			ViewData["Name"] = person.Name;

			return RedirectToAction("Contact", person);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
	public class Person
	{
		public string Name { get; set; }
		public string Email { get; set; }
	}
}
