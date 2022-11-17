using FerryFunctions;

Ferry test = new Ferry();
test.Board(new Car("yellow", 3));
test.Board(new Car("green", 3));
test.Board(new Car("pink", 3));
test.Board(new Car("red", 3));
test.Board(new Car("yellow", 3));
test.Board(new Car("yellow", 1));

Console.WriteLine(test.Board(new Car("yellow", 3)));

// foreach (var item in test.HowManyCars())
// {
//   Console.WriteLine(item);
// }
//Console.WriteLine(test.NumOfCars("yellow"));


