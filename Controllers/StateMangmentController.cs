using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;

namespace Day4.Controllers
{
	public class StateMangmentController : Controller
	{
		//StateMangment/FirstAction
		public IActionResult FirstAction()
		{
			//Can I have it stored on the server[builder.Services.AddControllersWithViews().AddSessionStateTempDataProvider()]
			//This is the first request that will be saved at the client level in the cookie.
			TempData["name"] = "Ali Abo Rashed";
	/*respons Temp Data Saved*/	return Content("TempData Saved");

		}
		public IActionResult SecondAction() {
			//In this case it does not save the data In order to save it at the
			//server level I must use Peek() or Keep(); 
			//var value = TempData["name"];
			//return Content(value.ToString());
			var value = TempData.Peek("name");
			return Content(value.ToString());
		}
		public IActionResult ThirdAction() {
			var value = TempData["name"];
			return Content(value.ToString());
		}

	}
}
