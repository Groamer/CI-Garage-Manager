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
            CarDetails carDetails = new CarDetails();
            carDetails.ShowDialog();

            UpdateCars();
            UpdateListView();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indices = ListViewCar.SelectedIndices;
            CarModel car = cars[indices[0]];

            CarDetails carDetails = new CarDetails(car.ToString());
            carDetails.ShowDialog();

            UpdateCars();
            UpdateListView();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (ListViewCar.SelectedItems.Count == 1)
            {
                var confirmation = MessageBox.Show("Do you really want to remove the selected car?",
                    "Confirm Removal",
                    MessageBoxButtons.YesNo);

                if(confirmation == DialogResult.Yes)
                {
                    ListView.SelectedIndexCollection indices = ListViewCar.SelectedIndices;
                    CarModel car = cars[indices[0]];
                    carsController.RemoveCar(car);

                    UpdateCars();
                    UpdateListView();
                }
            }
            else
            {
                var confirmation = MessageBox.Show("Do you really want to remove the selection of " + ListViewCar.SelectedItems.Count.ToString() + " cars?",
                    "Confirm Removal",
                    MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                    ListView.SelectedIndexCollection indices = ListViewCar.SelectedIndices;

                    foreach(int index in indices)
                    {
                        CarModel car = cars[index];
                        carsController.RemoveCar(car);
                    }

                    UpdateCars();
                    UpdateListView();
                }
            }
        }

        private void InitListView()
        {
            ListViewCar.View = View.Details;
            ListViewCar.HideSelection = false;
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

        private void Button100_Click(object sender, EventArgs e)
        {
            page = 1;
            shownItems = 100;
            UpdateCars();
            UpdateListView();
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
            }
            UpdateCars();
            UpdateListView();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            page++;
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

        private void LabelItems_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            page = 1;
            UpdateCars();
            UpdateListView();
        }

        private void ListViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ListViewCar.SelectedItems.Count)
            {
                case 0:
                    ButtonEdit.Enabled = false;
                    ButtonRemove.Enabled = false;
                    ButtonRemove.Text = "Remove Car";
                    break;
                case 1:
                    ButtonEdit.Enabled = true;
                    ButtonRemove.Enabled = true;
                    ButtonRemove.Text = "Remove Car";
                    break;
                case 2:
                    ButtonEdit.Enabled = false;
                    ButtonRemove.Enabled = true;
                    ButtonRemove.Text = "Remove Cars";
                    break;
            }
        }
    }
}
