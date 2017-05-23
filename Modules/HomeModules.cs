using Nancy;
using cardealer.Objects;
using System.Collections.Generic;

namespace cardealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_car.cshtml"];
      Get["/view_all_cars"] = _ =>{
        List<Car> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };
      Post["/car_added"] = _ => {
        Car newCar = new Car (Request.Form["new-car"],Request.Form["new-car-model"],Request.Form["new-car-year"],Request.Form["new-car-price"], Request.Form["new-car-mileage"]);
        newCar.Save();
        return View["cars_added.cshtml", newCar];
      };
      Post["/cars_cleared"] = _ => {
        Car.ClearAll();
        return View["cars_cleared.cshtml"];
      };
    }
  }
}
