using CI_Garage_Manager.Application.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI_Garage_Manager.Application.Controllers
{
    class CarController
    {
        private List<CarModel> cars;

        public CarController()
        {
            cars = new List<CarModel>();
        }

        public void LoadCars()
        {

        }

        public void CreateCar(CarModel car)
        {
            cars.Add(car);
        }

        public void EditCar(CarModel car, int ID)
        {
            cars[ID] = car;
        }

        public void RemoveCar(int ID)
        {
            cars.RemoveAt(ID);
        }

        public void PrintCars()
        {
            foreach (CarModel car in cars)
            {
                car.PrintCar();
            }
        }
    }
}
