using System.Collections.Generic;

namespace cardealer.Objects
{
  public class Car
  {
    private string _description;
    // private string _model;
    private static List<string> _instances = new List<string> {};

// CONSTRUCTOR
    public Car (string description)
    {
      _description = description;
      // _model = model;
    }
// RETURNS VARIABLE
    public string GetDescription()
    {
      return _description;
    }
    // public string GetModel()
    // {
    //   return _model;
    // }
// SETS VARIABLE
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    // public void SetModel(string newModel)
    // {
    //   _model = newModel;
    // }
//RETURNS LIST
    public static List<string> GetAll()
    {
      return _instances;
    }
//SAVES INSTANCES IN LIST
    public void Save()
    {
      _instances.Add(_description);
    }
  }
}
