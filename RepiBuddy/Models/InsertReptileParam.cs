namespace RepiBuddy.Models;

public class InsertReptileParam
{
	public IFormFile? ReptilePhoto { get; set; }
	public string? ReptileName { get; set; }
	public DateTime DOB { get; set; }
	public int ReptileType { get; set; }
	public int ReptileSpecies { get; set; }
	public string? Morph { get; set; }
}