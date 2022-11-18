using FerryFunctions;

Ferry test = new Ferry();
//test.Board(new Car("yellow", 3, "CA 123-568"));
// test.Board(new Car("yellow", 1, "CA 123-568"));
// test.Board(new Car("blue", 5, "CY 197-321"));
// test.Board(new Car("black", 7, "CF 188-568"));
// test.Board(new Car("black", 7, "CF 188-568"));
// test.Board(new Car("black", 7, "CF 188-568"));
// test.Board(new Car("silver grey", 4, "EC 444-468"));
// test.Board(new Car("white", 3, "CF 123-566"));
//test.Board(new Car("yellow", 2, "CA 123-568"));
test.Board(new Car("yellow", 2, "CA 123-568"));
test.Board(new Car("yellow", 1, "CA 123-568"));
test.Board(new Car("yellow", 3, "CA 123-568"));
test.Board(new Car("yellow", 4, "CA 123-568"));
test.Board(new Car("yellow", 2, "CA 123-568"));
test.Board(new Car("yellow", 2, "CA 123-568"));
test.Board(new Car("yellow", 2, "CA 123-568"));
test.Board(new Car("yellow", 1, "CA 123-568"));
// test.Board(new Car("yellow", 3, "CA 123-568"));
// test.Board(new Car("yellow", 4, "CA 123-568"));
// test.Board(new Car("yellow", 2, "CA 123-568"));


Console.WriteLine(test.Board(new Car("yellow", 3, "CA 123-568")));

foreach (var item in test.ShowCars())
{

  Console.WriteLine($"{item.Colour}, {item.PassengerCount}, {item.CarNumberPlate}");
  //Console.WriteLine(item);
}
Console.WriteLine(test.HowManyCars("purple"));
Console.WriteLine("*************************");
Console.WriteLine(test.UpdateCount(new Car("pink", 3, "CA 123-568")));





