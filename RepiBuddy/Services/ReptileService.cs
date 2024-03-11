using Microsoft.EntityFrameworkCore;
using RepiBuddy.Data;
using RepiBuddy.Models;
using SQLitePCL;

namespace RepiBuddy.Services;

public class ReptileService
{
	private readonly ReptileDbContext _context;

	public ReptileService(ReptileDbContext context) 
	{
		_context = context;
	}
	
	public async Task<IEnumerable<ReptileTypeModel>> GetReptileTypes() 
	{
		var types = await _context.Reptile_Type
			.Select(x => new ReptileTypeModel 
			{
				id = x.Id,
				Type = x.Type
			}).ToListAsync();
		
		return types;
	}
}