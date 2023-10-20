using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			int saat = DateTime.Now.Hour;
			ViewBag.selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
			int userCount = Repository.Users.Where(x => x.WillAttend == true).Count();


			var meetingInfo = new MeetingInfo()
			{
				Id = 1,
				Location = "İstanbul, Kongre Merkezi",
				Date = new DateTime(2024, 01, 21, 20, 0, 0),
				NumberOfPeople = userCount
			};

			return View(meetingInfo);
		}
	}
}
