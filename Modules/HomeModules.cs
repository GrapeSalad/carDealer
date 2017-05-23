using Nancy;
using cardealer.Objects;
using System.Collections.Generic;

namespace cardealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["add_new_car.cshtml"];
      };
      Get["/view_all_cars"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };
      Post["/car_added"] = _ => {
        Car newCar = new Car (Request.Form["new-car"], Request.Form["new-car-model"], Request.Form["new-car-year"], Request.Form["new-car-price"], Request.Form["new-car-mileage"]);
        int number = 0;
        bool isMakeNumber = int.TryParse(Request.Form["new-car"], out number);
        bool isModelNumber = int.TryParse(Request.Form["new-car-model"], out number);
        bool isYearNumber = int.TryParse(Request.Form["new-car-year"], out number);
        bool isPriceNumber = int.TryParse(Request.Form["new-car-price"], out number);
        bool isMileageNumber = int.TryParse(Request.Form["new-car-mileage"], out number);
        if((isYearNumber) && (isPriceNumber) && (isMileageNumber) && (!(isModelNumber)) && (!(isMakeNumber))){
          // newCar.Save();
          return View["cars_added.cshtml", newCar];
        }
        else {
          return View["dun_goofed.cshtml"];
        }
      };
      Post["/cars_cleared"] = _ => {
        Car.ClearAll();
        return View["cars_cleared.cshtml"];
      };
      Get["/view_all_cars/{id}"] = parameters => {
        Car car = Car.Find(parameters.id);
        return View["/car.cshtml", car];
      };
      Post["/view_all_cars/{id}"] = parameters => {
        Car car = Car.Find(parameters.id);
        car.Remove();
        List<Car> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };
    }
  }
}
