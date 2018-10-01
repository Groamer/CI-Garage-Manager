using CI_Garage_Manager.Models;
using CI_Garage_Manager.Controllers;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CI_Garage_Manager.Views
{
    public partial class CarDetails : Form
    {
        private CarModel car;
        private CarsController carsController;
        private string carString;

        public CarDetails()
        {
            InitializeComponent();
            this.Text = "Create Car - CI Garage Manager";
            carsController = new CarsController();
            car = new CarModel();
        }
        public CarDetails(string carString)
        {
            InitializeComponent();
            this.Text = "Edit Car - CI Garage Manager";
            car = new CarModel();
            carsController = new CarsController();
            this.carString = carString;
            SetCar();
            SetFields();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(carString == null)
            {
                car.SetMake(TextBoxMake.Text);
                car.SetModel(TextBoxModel.Text);
                if(TextBoxYear.Text != "")
                {
                    car.SetYear(Int32.Parse(TextBoxYear.Text));
                }
                car.SetEngine(TextBoxEngine.Text);
                car.SetVehicleID(TextBoxVehicleID.Text);
                car.SetPlate(TextBoxPlate.Text);

                carsController.CreateCar(car);
            }
            else
            {
                car.SetMake(TextBoxMake.Text);
                car.SetModel(TextBoxModel.Text);
                if (TextBoxYear.Text != "")
                {
                    car.SetYear(Int32.Parse(TextBoxYear.Text));
                }
                car.SetEngine(TextBoxEngine.Text);
                car.SetVehicleID(TextBoxVehicleID.Text);
                car.SetPlate(TextBoxPlate.Text);

                carsController.EditCar(car, carString);
            }

            Close();
        }

        private void SetCar()
        {
            string[] carDetails = carString.Split('\n');
            
            car.SetMake(carDetails[0]);
            car.SetModel(carDetails[1]);
            car.SetYear(Int32.Parse(carDetails[2]));
            car.SetEngine(carDetails[3]);
            car.SetVehicleID(carDetails[4]);
            car.SetPlate(carDetails[5]);
        }

        private void SetFields()
        {
            TextBoxMake.Text = car.GetMake();
            TextBoxModel.Text = car.GetModel();
            TextBoxYear.Text = car.GetYear().ToString();
            TextBoxEngine.Text = car.GetEngine();
            TextBoxVehicleID.Text = car.GetVehicleID();
            TextBoxPlate.Text = car.GetPlate();
        }

        private void TextBoxYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxYear.Text != "")
                {
                    Int32.Parse(TextBoxYear.Text);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Please fill in numbers only.", "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextBoxYear.Text = "";
                Console.WriteLine(error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
