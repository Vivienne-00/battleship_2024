namespace Battleship.Persistency
{
	public class User
	{
		public int UserId { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Salt { get; set; }
		public Accesslevel Accesslvl { get; set; }
		public bool Active { get; set; }
		//public int Birthyear { get; set; }
		//public List<Gameparticipation> Gameparticipations { get; } = new List<Gameparticipation>();
	}

}
