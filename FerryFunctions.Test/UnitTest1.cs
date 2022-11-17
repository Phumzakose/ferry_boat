namespace FerryFunctions.Test;

public class UnitTest1
{
   Ferry test = new Ferry();
  [Fact]
  public void ItShouldBeAbleToReturnAcceptedIfItDoesNotExceedNumberOfPeopleAndCars()
  {
    test.Board(new Car("yellow", 3));
    test.Board(new Car("Silver grey", 3));
    test.Board(new Car("blue", 3));
    test.Board(new Car("red", 3));

    Assert.Equal("Accepted", test.Board(new Car("black", 5)));

  }
  [Fact]
  public void ItShouldBeAbleToReturnRejectedIfItDoesExceedNumberOfPeopleAndCars()
  {
    test.Board(new Car("yellow", 6));
    test.Board(new Car("Silver grey", 3));
    test.Board(new Car("blue", 15));
    test.Board(new Car("red", 6));
    test.Board(new Car("black", 4));
    test.Board(new Car("grey", 5));
    test.Board(new Car("pink", 15));
    test.Board(new Car("white", 4));
    test.Board(new Car("yellow", 4));
    test.Board(new Car("Silver grey", 4));
    test.Board(new Car("blue", 5));
    test.Board(new Car("red", 5));

    Assert.Equal("Rejected", test.Board(new Car("marron", 5)));
  }
}