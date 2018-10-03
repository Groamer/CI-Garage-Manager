using CI_Garage_Manager.Models;
using CI_Garage_Manager.Controllers;

using System;
using System.Windows.Forms;

namespace CI_Garage_Manager.Views
{
    public partial class CarDetails : Form
    {
        private CarModel carNew;
        private CarModel carOld;
        private CarsController carsController;

        public CarDetails()
        {
            InitializeComponent();
            Text = "Create Car - CI Garage Manager";
            carsController = new CarsController();
            carNew = new CarModel();
        }
        public CarDetails(CarModel car)
        {
            InitializeComponent();
            Text = "Edit Car - CI Garage Manager";
            carNew = new CarModel();
            carOld = car;
            carsController = new CarsController();
            InitEdit();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            carNew.SetMake(TextBoxMake.Text);
            carNew.SetModel(TextBoxModel.Text);
            if (TextBoxYear.Text != "")
            {
                carNew.SetYear(Int32.Parse(TextBoxYear.Text));
            }
            carNew.SetEngine(TextBoxEngine.Text);
            carNew.SetVehicleID(TextBoxVehicleID.Text);
            carNew.SetPlate(TextBoxPlate.Text);

            if (carOld == null)
            {
                carsController.CreateCar(carNew);
            }
            else
            {
                carsController.EditCar(carNew, carOld);
            }

            Close();
        }

        private void InitEdit()
        {
            TextBoxMake.Text = carOld.GetMake();
            TextBoxModel.Text = carOld.GetModel();
            TextBoxYear.Text = carOld.GetYear().ToString();
            TextBoxEngine.Text = carOld.GetEngine();
            TextBoxVehicleID.Text = carOld.GetVehicleID();
            TextBoxPlate.Text = carOld.GetPlate();
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
