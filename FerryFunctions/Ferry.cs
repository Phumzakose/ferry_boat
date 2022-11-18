namespace FerryFunctions;

public class Ferry
{

  public int PeopleCount { get; set; }
  public int CarsCount { get; set; }
  public int numberOfCars;
  public int numberOfPeople;
  List<KeyValuePair<string, int>> cars = new List<KeyValuePair<string, int>>();

  public List<Car> carsList = new List<Car>();

  public Ferry()
  {
    numberOfCars = 20;
    numberOfPeople = 50;
  }


  public string Board(Car car)
  {
    string message = "";

    if (numberOfCars >= CarsCount && numberOfPeople >= PeopleCount)
    {
      int count = 0;
      PeopleCount += car.PassengerCount;
      CarsCount++;
      cars.Add(new KeyValuePair<string, int>(car.Colour!, car.PassengerCount));
      carsList.Add(new Car(car.Colour!, car.PassengerCount, car.CarNumberPlate));
      foreach (var item in carsList)
      {
        if (item.CarNumberPlate == car.CarNumberPlate && item.Colour == car.Colour) count++;
        if (count == 7 && count < 8)
        {
          message = "You go free!!";
        }
        else if (count >= 3 && count < 7)
        {
          message = "Half Price!!";

        }
        else
        {
          message = "Accepted";
        }
      }
    }
    else
    {
      message = "Rejected";
    }
    return message;

  }
  public List<Car> ShowCars()
  {
    return carsList;
  }

  public string HowManyCars(string carColour)
  {
    string message = "";
    int count = 0;
    foreach (var item in cars)
    {
      if (item.Key == carColour) count++;
      if (count >= 1)
      {
        message = "We have " + count + " car/s in the ferry with the " + carColour + "Colour";
      }
      else
      {
        message = "There are no cars in the ferry with that colour";
      }
    }
    return message;
  }

  public string UpdateCount(Car car)
  {
    if (cars.Contains(new KeyValuePair<string, int>(car.Colour!, car.PassengerCount)))
    {

      cars.Remove(new KeyValuePair<string, int>(car.Colour!, car.PassengerCount));
      CarsCount--;
      PeopleCount -= car.PassengerCount;
      return "The car departed only " + CarsCount + " cars left and " + PeopleCount + " people left";

    }
    else
    {
      return "The car is not on board";
    }

  }

}