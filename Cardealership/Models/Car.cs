using System;
using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
    // Public auto-implemented properties
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _carList = new List<Car> {};

    //Constructor
    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _carList.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _carList;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }
    
    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }
    
    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static void ClearAll()
    {
      _carList.Clear();
    }
  }
}
