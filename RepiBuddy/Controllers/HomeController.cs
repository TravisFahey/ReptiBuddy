using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using RepiBuddy.Models;
using RepiBuddy.Services;

namespace RepiBuddy.Controllers;

public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;
	private readonly IWebHostEnvironment _hostEnvironment;
	private readonly ReptileService _reptileService;

	public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment, ReptileService reptileService)
	{
		_logger = logger;
		_hostEnvironment = hostEnvironment;
		_reptileService = reptileService;
	}

	public IActionResult Index()
	{
		return View();
	}
	
	public IActionResult AddReptile() 
	{
		return View();
	}
	
	public IActionResult InsertReptile([FromForm] InsertReptileModel model)
	{
		return Ok();
	}
	
	[HttpGet]
	public async Task<JsonResult> GetReptileTypes() 
	{
		var types = await _reptileService.GetReptileTypes();
		
		return Json(types);
	}
	
	[HttpGet]
	public async Task<JsonResult> GetReptileSpecies(int typeId) 
	{
		var species = await _reptileService.GetReptileSpecies(typeId);
		
		return Json(species);
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
