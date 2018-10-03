using System;

namespace CI_Garage_Manager_Server.Models
{
    [Serializable]
    public class CarModel
    {
        private string make;
        private string model;
        private int year;
        private string engine;
        private string vehicleID;
        private string plate;

        public string GetMake()
        {
            return make;
        }
        public void SetMake(string make)
        {
            this.make = make;
        }

        public string GetModel()
        {
            return model;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }

        public int GetYear()
        {
            return year;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }

        public string GetEngine()
        {
            return engine;
        }
        public void SetEngine(string engine)
        {
            this.engine = engine;
        }

        public string GetVehicleID()
        {
            return vehicleID;
        }
        public void SetVehicleID(string vehicleID)
        {
            this.vehicleID = vehicleID;
        }

        public string GetPlate()
        {
            return plate;
        }
        public void SetPlate(string plate)
        {
            this.plate = plate;
        }

        override public string ToString()
        {
            return make + "[[CarModel]]" + model + "[[CarModel]]" + year.ToString() + "[[CarModel]]" + engine + "[[CarModel]]" + vehicleID + "[[CarModel]]" + plate;
        }
    }
}
