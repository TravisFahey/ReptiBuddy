namespace RepiBuddy.Models.Domain 
{
	public class User_Reptiles
	{
		public int Id { get; set; }
		public string ReptileName { get; set; }
		public string ReptileType { get; set; }
		public string ReptileSpecies { get; set; }
		public DateTime DOB { get; set; }
		public int Morph { get; set; }
		public int UserID { get; set; }
		
	}
}