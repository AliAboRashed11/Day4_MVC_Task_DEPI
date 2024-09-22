using Microsoft.AspNetCore.Mvc;

namespace Day4.Controllers
{
	public class SessionMangmentController : Controller
	{
		//SessionMangment/SessionSet

		//When running In this case it will happen 2 Error
		//1-Configure:the solution go to program.cs in Main use [app.UseSession();]
		//2-Configure:the solution go to program.cs in Main use [builder.Services.AddSession();]
		public IActionResult SessionSet() {
			// In this case it will be saved at the server level.
			HttpContext.Session.SetString("name", "Ahmed Ali");
			HttpContext.Session.SetInt32("Age",23);
			return Content("Saved Data");
		}

		public IActionResult SessionGet() {
			string NameValue = HttpContext.Session.GetString("name");
			int? AgeValue = HttpContext.Session.GetInt32("Age");

			return Content($"Name : {NameValue},Age : {AgeValue}");
		}
		public IActionResult SessionGet3()
		{
			string NameValue = HttpContext.Session.GetString("name");
			int? AgeValue = HttpContext.Session.GetInt32("Age");

			return Content($"Name : {NameValue},Age : {AgeValue}");
		}
	}
}
