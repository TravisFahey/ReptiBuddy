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
	
	public async Task<IEnumerable<ReptileSpeciesModel>> GetReptileSpecies(int typeId) 
	{
		var species = await _context.Reptile_Species
			.Where(x => x.Type == typeId)
			.Select(x => new ReptileSpeciesModel
				{
					id = x.Id,
					Species = x.Species
				}).ToListAsync();
			
		return species;
	}
}