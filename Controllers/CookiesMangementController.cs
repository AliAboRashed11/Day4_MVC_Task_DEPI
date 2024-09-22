using Microsoft.AspNetCore.Mvc;

namespace Day4.Controllers
{
	public class CookiesMangementController : Controller
	{
		public IActionResult SetCookies()
		{
			//This is the first request that will be saved at the client level in the cookie.
			CookieOptions cookieOptions = new CookieOptions();
			cookieOptions.Expires = DateTime.Now.AddDays(4);
			HttpContext.Response.Cookies.Append("FirstName", "Ali", cookieOptions);
			HttpContext.Response.Cookies.Append("LastName", "Siam", cookieOptions);

			return Content("Saved Data");
		}

		public IActionResult getCookies()
		{
			
		string fname = HttpContext.Request.Cookies["FirstName"];
			string lname = HttpContext.Request.Cookies["LastName"];

			return Content($"firstName:{fname} , LastName : {lname}");
		}

		public IActionResult getCookies2()
		{
			string fname = HttpContext.Request.Cookies["FirstName"];
			string lname = HttpContext.Request.Cookies["LastName"];

			return Content($"firstName:{fname} , LastName : {lname}");
		}
	}
}
