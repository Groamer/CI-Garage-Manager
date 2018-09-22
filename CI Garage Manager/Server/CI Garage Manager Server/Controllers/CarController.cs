using CI_Garage_Manager_Server.Models;

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CI_Garage_Manager_Server.Controllers
{
    class CarController
    {
        private List<CarModel> cars;
        private readonly string path;

        public CarController()
        {
            cars = new List<CarModel>();
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + "\\ComputerInfor\\CI Garage Manager";

            Load();
        }

        public void Save()
        {
            Directory.CreateDirectory(path);

            try
            {
                Stream stream = File.OpenWrite(path + "\\Cars.dat");
                BinaryFormatter binaryFormatter = new BinaryFormatter();
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
                BinaryFormatter binaryFormatter = new BinaryFormatter();
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

        public void Create(CarModel car)
        {
            cars.Add(car);
        }

        public void Edit(CarModel car, int ID)
        {
            cars[ID] = car;
        }

        public void Remove(int ID)
        {
            cars.RemoveAt(ID);
        }

        public List<CarModel> GetCars()
        {
            return cars;
        }

        public List<CarModel> Search(string input)
        {
            List<CarModel> carList = new List<CarModel>();
            string[] terms = input.Split(' ');

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

            return carList;
        }

        public List<CarModel> Sort()
        {
            List<CarModel> carList = new List<CarModel>();

            return carList;
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
