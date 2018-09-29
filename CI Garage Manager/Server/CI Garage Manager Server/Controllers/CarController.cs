using CI_Garage_Manager_Server.Models;

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CI_Garage_Manager_Server.Controllers
{
    class CarController
    {
        BinaryFormatter binaryFormatter;

        private List<CarModel> cars;
        private readonly string path;

        public CarController()
        {
            binaryFormatter = new BinaryFormatter();

            cars = new List<CarModel>();
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + "\\ComputerInfor\\CI Garage Manager Server";

            Load();
        }

        public void Save()
        {
            Directory.CreateDirectory(path);

            try
            {
                Stream stream = File.OpenWrite(path + "\\Cars.dat");
                binaryFormatter.Serialize(stream, cars);
                stream.Flush();
                stream.Close();
                stream.Dispose();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        public void Load()
        {
            try
            {
                FileStream fileStream = File.Open(path + "\\Cars.dat", FileMode.Open);
                object carList = binaryFormatter.Deserialize(fileStream);
                cars = (List<CarModel>)carList;
                fileStream.Flush();
                fileStream.Close();
                fileStream.Dispose();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        public void Create(string carString)
        {
            CarModel car = new CarModel();
            string[] carDetails = carString.Split('\n');

            car.SetMake(carDetails[0]);
            car.SetModel(carDetails[1]);
            car.SetYear(Int32.Parse(carDetails[2]));
            car.SetEngine(carDetails[3]);
            car.SetVehicleID(carDetails[4]);
            car.SetPlate(carDetails[5]);

            cars.Add(car);
        }

        public void Edit(string carString, int ID)
        {
            CarModel car = new CarModel();
            string[] carDetails = carString.Split('\n');

            car.SetMake(carDetails[0]);
            car.SetModel(carDetails[1]);
            car.SetYear(Int32.Parse(carDetails[2]));
            car.SetEngine(carDetails[3]);
            car.SetVehicleID(carDetails[4]);
            car.SetPlate(carDetails[5]);

            try
            {
                cars[ID] = car;
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        public void Remove(int ID)
        {
            try
            {
                cars.RemoveAt(ID);
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        public string Get(int page, int shownItems)
        {
            string carList = "CarList";
            int firstItem = (page * shownItems) - shownItems;
            int lastItem = firstItem + shownItems;

            for (int i = firstItem; i < lastItem; i++)
            {
                if (i + 1 > cars.Count)
                {
                    break;
                }
                else
                {
                    carList += "|" + cars[i].ToString();
                }
            }

            return carList;
        }

        public string Search(string input, int page, int shownItems)
        {
            List<CarModel> carList = new List<CarModel>();
            string[] terms = input.Split(' ');
            string carString = "CarList";
            int firstItem = (page * shownItems) - shownItems;
            int lastItem = firstItem + shownItems;

            foreach (CarModel car in cars)
            {
                Boolean hit = true;

                foreach (string term in terms)
                {
                    if (!car.ToString().ToLowerInvariant().Contains(term.ToLowerInvariant()))
                    {
                        hit = false;
                    }
                }

                if (hit)
                {
                    carList.Add(car);
                }
            }

            for (int i = firstItem; i < lastItem; i++)
            {
                if (i + 1 > carList.Count)
                {
                    break;
                }
                else
                {
                    carString += "|" + carList[i].ToString();
                }
            }

            return carString;
        }

        public void PrintCars()
        {
            foreach (CarModel car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
