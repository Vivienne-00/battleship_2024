namespace Battleship.Model.ShipModel
{
	public class ShipCreator
	{
		public static Ship GetNewShip(Ship ship)
		{
			switch (ship.shipType)
			{
				case "Battleship":
					return new Battleship();
				case "Cruiser":
					return new Cruiser();
				case "Destroyer":
					return new Destroyer();
				case "Submarine":
					return new Submarine();
			}
			return null;
		}
	}
}
