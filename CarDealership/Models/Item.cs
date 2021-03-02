using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel ;
    public int Price;
    public int Miles;
    private static List<Car> _instances = new List<Car> {};
    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}