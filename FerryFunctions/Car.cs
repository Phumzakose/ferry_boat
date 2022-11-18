namespace FerryFunctions;


public class Car
{
  public string? Colour { get; }

  public int PassengerCount { get; }
  public string CarNumberPlate { get; }


  public Car(string carColour, int passengers, string numberplate)
  {
    Colour = carColour;
    PassengerCount = passengers;
    CarNumberPlate = numberplate;

  }


}
