using System.Collections.Generic;

namespace cardealer.Objects
{
  public class Car
  {
    private string _description;
    private string _model;
    private string _year;
    private string _price;
    private string _mileage;
    private static List<Car> _instances = new List<Car> {};

// CONSTRUCTOR
    public Car (string description, string model, string year, string price, string mileage)
    {
      _description = description;
      _model = model;
      _year = year;
      _price = price;
      _mileage = mileage;
    }
// RETURNS VARIABLE
    public string GetDescription()
    {
      return _description;
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
// SETS VARIABLE
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
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
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
