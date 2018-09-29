using CI_Garage_Manager.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI_Garage_Manager.Controllers
{
    public class CarsController
    {
        public CarsController()
        {
            
        }

        public List<CarModel> GetCars(int page, int shownItems)
        {
            Client client = new Client();
            return ExtractCars(client.SendCommand("CarGet|" + page.ToString() + "|" + shownItems.ToString()));
        }

        public List<CarModel> SearchCar(string input, int page, int shownItems)
        {
            Client client = new Client();
            return ExtractCars(client.SendCommand("CarSearch|" + input + "|" + page.ToString() + "|" + shownItems.ToString()));
        }

        public void CreateCar(CarModel car)
        {
            Client client = new Client();
            Console.WriteLine(client.SendCommand("CarCreate|" + car.ToString()));
        }

        public void EditCar(int index)
        {

        }

        public void RemoveCar(int index)
        {
            Client client = new Client();
            Console.WriteLine(client.SendCommand("CarRemove|" + index.ToString()));
        }

        private List<CarModel> ExtractCars(string data)
        {
            List<CarModel> carList = new List<CarModel>();
            string[] protocol = data.Split('|');

            if(protocol[0] == "CarList")
            {
                for(int i = 1; i < protocol.Count(); i ++)
                {
                    CarModel car = new CarModel();
                    string[] carString = protocol[i].Split('\n');

                    car.SetMake(carString[0]);
                    car.SetModel(carString[1]);
                    car.SetYear(Int32.Parse(carString[2]));
                    car.SetEngine(carString[3]);
                    car.SetVehicleID(carString[4]);
                    car.SetPlate(carString[5]);

                    carList.Add(car);
                }
            }

            return carList;
        }
    }
}
