using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI_Garage_Manager.Application.Models
{
    class CarModel
    {
        private string make;
        private string model;
        private int year;
        private string engine;
        private string vehicleID;
        private string plate;
        
        public string GetMake()
        {
            return this.make;
        }
        public void SetMake(string make)
        {
            this.make = make;
        }

        public string GetModel()
        {
            return this.model;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }

        public int GetYear()
        {
            return this.year;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }

        public string GetEngine()
        {
            return this.engine;
        }
        public void SetEngine(string engine)
        {
            this.engine = engine;
        }

        public string GetVehicleID()
        {
            return this.vehicleID;
        }
        public void SetVehicleID(string vehicleID)
        {
            this.vehicleID = vehicleID;
        }

        public string GetPlate()
        {
            return this.plate;
        }
        public void SetPlate(string plate)
        {
            this.plate = plate;
        }

        public void PrintCar()
        {
            Console.WriteLine("Make: " + this.make + "\nModel: " + this.model + "\n");
        }
    }
}
