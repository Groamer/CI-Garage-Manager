using CI_Garage_Manager.Models;
using CI_Garage_Manager.Controllers;

using System;
using System.Windows.Forms;

namespace CI_Garage_Manager.Views
{
    public partial class JobDetails : Form
    {
        private int carID;
        private JobModel jobNew;
        private JobModel jobOld;
        JobsController jobsController;

        public JobDetails(int carID)
        {
            InitializeComponent();
            Text = "Create Job - CI Garage Manager";
            this.carID = carID;
            jobsController = new JobsController();
            jobNew = new JobModel();
        }
        public JobDetails(JobModel job)
        {
            InitializeComponent();
            Text = "Edit Job - CI Garage Manager";
            carID = job.GetCarID();
            jobNew = new JobModel();
            jobOld = job;
            jobsController = new JobsController();
            InitEdit();
        }

        private void InitEdit()
        {
            DateTimeStart.Text = jobOld.GetStartDate();
            DateTimeEnd.Text = jobOld.GetEndDate();
            TextBoxProblem.Text = jobOld.GetProblem();
            TextBoxSolution.Text = jobOld.GetSolution();
            TextBoxMilage.Text = jobOld.GetMilage().ToString();
            TextBoxCost.Text = jobOld.GetCost().ToString();
            TextBoxRevenue.Text = jobOld.GetRevenue().ToString();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            jobNew.SetCarID(carID);
            jobNew.SetStartDate(DateTimeStart.Text);
            jobNew.SetEndDate(DateTimeEnd.Text);
            jobNew.SetProblem(TextBoxProblem.Text);
            jobNew.SetSolution(TextBoxSolution.Text);
            if (TextBoxMilage.Text != "")
            {
                jobNew.SetMilage(Int32.Parse(TextBoxMilage.Text));
            }
            if (TextBoxCost.Text != "")
            {
                jobNew.SetCost(float.Parse(TextBoxCost.Text));
            }
            if (TextBoxRevenue.Text != "")
            {
                jobNew.SetRevenue(float.Parse(TextBoxRevenue.Text));
            }

            if (jobOld == null)
            {
                jobsController.CreateJob(jobNew);
            }
            else
            {
                jobsController.EditJob(jobNew, jobOld);
            }

            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxMilage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxMilage.Text != "")
                {
                    Int32.Parse(TextBoxMilage.Text);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Please fill in numbers only.", "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextBoxMilage.Text = "";
                Console.WriteLine(error);
            }
        }

        private void TextBoxCost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxCost.Text != "")
                {
                    float.Parse(TextBoxCost.Text);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Please fill in numbers only.", "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextBoxCost.Text = "";
                Console.WriteLine(error);
            }
        }

        private void TextBoxRevenue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxRevenue.Text != "")
                {
                    float.Parse(TextBoxRevenue.Text);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Please fill in numbers only.", "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextBoxRevenue.Text = "";
                Console.WriteLine(error);
            }
        }
    }
}
