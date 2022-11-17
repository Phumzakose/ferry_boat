namespace FerryFunctions;


public class Car
{
  public string? Colour { get; }

  public int PassengerCount { get; }


  public Car(string carColour, int passengers)
  {
    Colour = carColour;
    PassengerCount = passengers;
  }


}
