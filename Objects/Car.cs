using System.Collections.Generic;

namespace cardealer.Objects
{
  public class Car
  {
    private string _make;
    private string _model;
    private string _year;
    private string _price;
    private string _mileage;
    private int _id;
    private static List<Car> _instances = new List<Car> {};

// CONSTRUCTOR
    public Car (string make, string model, string year, string price, string mileage)
    {
      _make = make;
      _model = model;
      _year = year;
      _price = price;
      _mileage = mileage;
      _instances.Add(this);
      _id = _instances.Count;
    }
// RETURNS VARIABLE
    public string GetMake()
    {
      return _make;
    }
    public string GetModel()
    {
      return _model;
    }
    public string GetYear()
    {
      return _year;
    }
    public string GetPrice()
    {
      return _price;
    }
    public string GetMileage()
    {
      return _mileage;
    }
    public int GetId()
    {
      return _id;
    }
// SETS VARIABLE
    public void SetMake(string newMake)
    {
      _make = newMake;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }
    public void SetYear(string newYear)
    {
      _year = newYear;
    }
    public void SetPrice(string newPrice)
    {
      _price = newPrice;
    }
    public void SetMileage(string newMileage)
    {
      _price = newMileage;
    }
//RETURNS LIST
    public static List<Car> GetAll()
    {
      return _instances;
    }
//SAVES INSTANCES IN LIST
    // public void Save()
    // {
    //   _instances.Add(this);
    // }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Car Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public void Remove()
    {
      _instances.Remove(this);
    }
  }
}
