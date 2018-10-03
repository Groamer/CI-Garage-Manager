using CI_Garage_Manager.Models;
using CI_Garage_Manager.Controllers;

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace CI_Garage_Manager.Views
{
    public partial class Jobs : Form
    {
        private JobsController jobsController;
        private CarModel car;
        private List<JobModel> jobs;

        private int carID;
        private int page;
        private int shownItems;

        public Jobs(CarModel car, string carID)
        {
            InitializeComponent();

            this.car = car;
            this.carID = Int32.Parse(carID.Replace("Index:", ""));
            page = 1;
            shownItems = 20;
            jobsController = new JobsController();
            Text = car.GetMake() + " " + car.GetModel() + " Jobs - CI Garage Manager";
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            JobDetails jobDetails = new JobDetails(carID);
            jobDetails.ShowDialog();

            UpdateJobs();
            UpdateListView();
        }

        private void Jobs_Load(object sender, EventArgs e)
        {
            InitListView();
            jobs = jobsController.GetJobs(carID, page, shownItems);
            UpdateListView();
        }

        private void ToolStripMenuSave_Click(object sender, EventArgs e)
        {
            jobsController.SaveJobs();
        }

        private void ToolStripMenuInformation_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.ShowDialog();
        }

        private void ToolStripMenuComputerInfor_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.computerinfor.nl");
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            page = 1;
            shownItems = 20;
            UpdateJobs();
            UpdateListView();
        }

        private void Button50_Click(object sender, EventArgs e)
        {
            page = 1;
            shownItems = 50;
            UpdateJobs();
            UpdateListView();
        }

        private void Button100_Click(object sender, EventArgs e)
        {
            page = 1;
            shownItems = 100;
            UpdateJobs();
            UpdateListView();
        }

        private void UpdateJobs()
        {
            if (TextBoxSearch.Text != "")
            {
                jobs = jobsController.SearchJob(TextBoxSearch.Text, carID, page, shownItems);
            }
            else
            {
                jobs = jobsController.GetJobs(carID, page, shownItems);
            }
        }

        private void InitListView()
        {
            ListViewJob.View = View.Details;
            ListViewJob.HideSelection = false;
            ListViewJob.FullRowSelect = true;

            ListViewJob.Columns.Add("Start Date", 175, HorizontalAlignment.Left);
            ListViewJob.Columns.Add("End Date", 175, HorizontalAlignment.Left);
            ListViewJob.Columns.Add("Milage (km)", 80, HorizontalAlignment.Left);
            ListViewJob.Columns.Add("Cost (€)", 80, HorizontalAlignment.Left);
            ListViewJob.Columns.Add("Revenue (€)", 80, HorizontalAlignment.Left);
        }

        private void UpdateListView()
        {
            TextBoxPage.Text = page.ToString();

            ListViewJob.Items.Clear();

            foreach (JobModel job in jobs)
            {
                string[] row = {job.GetStartDate(), job.GetEndDate(), job.GetMilage().ToString(), job.GetCost().ToString(), job.GetRevenue().ToString()};
                ListViewItem item = new ListViewItem(row);
                ListViewJob.Items.Add(item);
            }
        }

        private void TextBoxPage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxPage.Text != "")
                {
                    int check = Int32.Parse(TextBoxPage.Text);

                    if (check > 0)
                    {
                        page = check;
                        UpdateJobs();
                        UpdateListView();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Please fill in numbers only.", "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextBoxPage.Text = page.ToString();
                Console.WriteLine(error);
            }
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
            }
            UpdateJobs();
            UpdateListView();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            page++;
            UpdateJobs();
            UpdateListView();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            page = 1;
            UpdateJobs();
            UpdateListView();
        }

        private void ListViewJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ListViewJob.SelectedItems.Count)
            {
                case 0:
                    ButtonEdit.Enabled = false;
                    ButtonRemove.Enabled = false;
                    ButtonRemove.Text = "Remove Job";
                    break;
                case 1:
                    ButtonEdit.Enabled = true;
                    ButtonRemove.Enabled = true;
                    ButtonRemove.Text = "Remove Job";
                    break;
                case 2:
                    ButtonEdit.Enabled = false;
                    ButtonRemove.Enabled = true;
                    ButtonRemove.Text = "Remove Jobs";
                    break;
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indices = ListViewJob.SelectedIndices;
            JobModel job = jobs[indices[0]];

            JobDetails jobDetails = new JobDetails(job);
            jobDetails.ShowDialog();

            UpdateJobs();
            UpdateListView();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (ListViewJob.SelectedItems.Count == 1)
            {
                var confirmation = MessageBox.Show("Do you really want to remove the selected job?",
                    "Confirm Removal",
                    MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                    ListView.SelectedIndexCollection indices = ListViewJob.SelectedIndices;
                    JobModel job = jobs[indices[0]];
                    jobsController.RemoveJob(job);

                    UpdateJobs();
                    UpdateListView();
                }
            }
            else
            {
                var confirmation = MessageBox.Show("Do you really want to remove the selection of " + ListViewJob.SelectedItems.Count.ToString() + " jobs?",
                    "Confirm Removal",
                    MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                    ListView.SelectedIndexCollection indices = ListViewJob.SelectedIndices;

                    foreach (int index in indices)
                    {
                        JobModel job = jobs[index];
                        jobsController.RemoveJob(job);
                    }

                    UpdateJobs();
                    UpdateListView();
                }
            }
        }

        private void ListViewJob_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indices = ListViewJob.SelectedIndices;
            JobModel job = jobs[indices[0]];

            string title = car.GetMake() + " " + car.GetModel() + " ";

            JobOverview jobOverview = new JobOverview(job, title);
            jobOverview.ShowDialog();
        }
    }
}
