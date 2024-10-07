using Microsoft.EntityFrameworkCore;
using ReptiBuddy.Data;
using ReptiBuddy.Models;
using SQLitePCL;

namespace ReptiBuddy.Services;

public class ReptileService
{
	private readonly ReptileDbContext _context;

	public ReptileService(ReptileDbContext context) 
	{
		_context = context;
	}
	
	public async Task<IEnumerable<ReptileType>> GetReptileTypes() 
	{
		var types = await _context.Reptile_Type
			.Select(x => new ReptileType 
			{
				id = x.Id,
				Type = x.Type
			}).ToListAsync();
		
		return types;
	}
	
	public async Task<IEnumerable<ReptileSpecies>> GetReptileSpecies(int typeId) 
	{
		var species = await _context.Reptile_Species
			.Where(x => x.Type == typeId)
			.Select(x => new ReptileSpecies
				{
					id = x.Id,
					Species = x.Species
				}).ToListAsync();
			
		return species;
	}
}