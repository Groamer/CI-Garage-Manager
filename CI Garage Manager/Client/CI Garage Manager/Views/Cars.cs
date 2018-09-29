using System;
using System.Collections.Generic;
using System.ComponentModel;
using CI_Garage_Manager.Models;
using CI_Garage_Manager.Controllers;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CI_Garage_Manager.Views
{
    public partial class Cars : Form
    {
        private CarsController carsController;
        private List<CarModel> cars;
        private int page;
        private int shownItems;

        public Cars()
        {
            InitializeComponent();
            carsController = new CarsController();
            cars = new List<CarModel>();
            page = 1;
            shownItems = 20;
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            InitListView();
            cars = carsController.GetCars(page, shownItems);
            UpdateListView();
        }

        private void CreateCar_Click(object sender, EventArgs e)
        {
            //carsController.CreateCar();
        }

        private void InitListView()
        {
            ListViewCar.View = View.Details;
            ListViewCar.FullRowSelect = true;

            ListViewCar.Columns.Add("Make", 100, HorizontalAlignment.Left);
            ListViewCar.Columns.Add("Model", 100, HorizontalAlignment.Left);
            ListViewCar.Columns.Add("Year", 40, HorizontalAlignment.Left);
            ListViewCar.Columns.Add("Engine", 100, HorizontalAlignment.Left);
            ListViewCar.Columns.Add("VIN", 100, HorizontalAlignment.Left);
            ListViewCar.Columns.Add("License Plate", 80, HorizontalAlignment.Left);
        }

        private void UpdateListView()
        {
            TextBoxPage.Text = page.ToString();

            ListViewCar.Items.Clear();

            foreach(CarModel car in cars)
            {
                string[] row = { car.GetMake(), car.GetModel(), car.GetYear().ToString(), car.GetEngine(), car.GetVehicleID(), car.GetPlate() };
                ListViewItem item = new ListViewItem(row);
                ListViewCar.Items.Add(item);
            }
        }

        private void UpdateCars()
        {
            if(TextBoxSearch.Text != "")
            {
                cars = carsController.SearchCar(TextBoxSearch.Text, page, shownItems);
            }
            else
            {
                cars = carsController.GetCars(page, shownItems);
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            page = 1;
            shownItems = 10;
            UpdateCars();
            UpdateListView();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            page = 1;
            shownItems = 20;
            UpdateCars();
            UpdateListView();
        }

        private void Button50_Click(object sender, EventArgs e)
        {
            page = 1;
            shownItems = 50;
            UpdateCars();
            UpdateListView();
        }

        private void TextBoxPage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(TextBoxPage.Text != "")
                {
                    page = Int32.Parse(TextBoxPage.Text);
                    UpdateCars();
                    UpdateListView();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Please fill in numbers only.", "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextBoxPage.Text = page.ToString();
                Console.WriteLine(error);
            }
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if(page > 1)
            {
                page --;
            }
            UpdateCars();
            UpdateListView();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            page ++;
            UpdateCars();
            UpdateListView();
        }

        private void LabelItems_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            page = 1;
            UpdateCars();
            UpdateListView();
        }
    }
}
