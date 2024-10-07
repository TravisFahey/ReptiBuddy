namespace ReptiBuddy.Models;

public class InsertReptileModel 
{
	public byte[]? ReptilePhoto { get; set; }
	public string? ReptileName { get; set; }
	public DateTime DOB { get; set; }
	public string? ReptileType { get; set; }
	public string? ReptileSpecies { get; set; }
	public string? Morph { get; set; }
}