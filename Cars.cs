using System;
using System.Collections.Generic;

class Car
{
  private string _MakeModel;
  private int _Price;
  private int _Miles;
  private string _Message;


  public void SetMessage(string newMessage)
  {
    _Message = newMessage;
  }

  public string GetMessage()
  {
    return _Message;
  }

  public void SetModel(string newModel)
  {
    _MakeModel = newModel;
  }

  public string GetModel()
  {
    return _MakeModel;
  }

  public void SetPrice(int newPrice)
  {
    _Price = newPrice;
  }

  public int GetPrice()
  {
    return _Price;
  }

  public void SetMiles(int newMiles)
  {
    _Miles = newMiles;
  }

  public int GetMiles()
  {
    return _Miles;
  }

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return (_Price < maxPrice && _Miles < maxMiles);
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.SetModel("2014 Porsche 911");
    porsche.SetPrice(114991);
    porsche.SetMiles(7864);
    porsche.SetMessage("Brand spankin new");

    Car ford = new Car();
    ford.SetModel("2011 Ford F450");
    ford.SetPrice(55995);
    ford.SetMiles(14241);
    ford.SetMessage("Brand spankin new");

    Car lexus = new Car();
    lexus.SetModel("2013 Lexus RX 350");
    lexus.SetPrice(44700);
    lexus.SetMiles(20000);
    lexus.SetMessage("Brand spankin new");

    Car mercedes = new Car();
    mercedes.SetModel("Mercedes Benz CLS550");
    mercedes.SetPrice(39900);
    mercedes.SetMiles(37979);
    mercedes.SetMessage("Brand spankin new");

    Car tesla = new Car();
    tesla.SetModel("Model Z");
    tesla.SetPrice(527912);
    tesla.SetMiles(200);
    tesla.SetMessage("Brand spankin new");

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes, tesla };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
      if (maxPrice <= 39900 || maxMiles <= 200)
      {
        Console.WriteLine("No results. Please reenter search.");
      }

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
        Console.WriteLine(automobile.GetModel() + automobile.GetMessage());
    }
  }
}
