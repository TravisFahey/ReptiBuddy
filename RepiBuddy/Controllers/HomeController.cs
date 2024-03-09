using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RepiBuddy.Models;

namespace RepiBuddy.Controllers;

public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;
	private readonly IWebHostEnvironment _hostEnvironment;

	public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment)
	{
		_logger = logger;
		_hostEnvironment = hostEnvironment;
	}

	public IActionResult Index()
	{
		return View();
	}
	
	public IActionResult AddReptile() 
	{
		return View();
	}
	
	public IActionResult GetImage(string filename)
		{
			var path = Path.Combine(_hostEnvironment.WebRootPath, "img", filename);
			var imageFileStream = System.IO.File.OpenRead(path);
			return File(imageFileStream, "image/jpeg");
		}
	
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
