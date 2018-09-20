using CI_Garage_Manager.Application.Models;

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI_Garage_Manager.Application.Controllers
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

        public void Search(string input)
        {

        }

        public void Sort()
        {

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
