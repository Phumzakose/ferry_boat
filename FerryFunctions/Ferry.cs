namespace FerryFunctions;

public class Ferry
{

  public int PeopleCount { get; set; }
  public int CarsCount { get; set; }
  public int numberOfCars;
  public int numberOfPeople;


  public Ferry()
  {
    numberOfCars = 5;
    numberOfPeople = 20;
  }


  public string Board(Car car)
  {

    if (numberOfCars >= CarsCount && numberOfPeople >= PeopleCount)
    {
      PeopleCount += car.PassengerCount;
      CarsCount++;

      return "Accepted";
    }
    else
    {
      return "Rejected";
    }

  }




}