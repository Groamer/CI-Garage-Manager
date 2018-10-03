using CI_Garage_Manager.Models;

using System.Windows.Forms;

namespace CI_Garage_Manager.Views
{
    public partial class JobOverview : Form
    {
        public JobOverview(JobModel job, string title)
        {
            InitializeComponent();

            Text = title + "Job - CI Garage Manager";

            TextBoxStart.Text = job.GetStartDate();
            TextBoxEnd.Text = job.GetEndDate();
            TextBoxProblem.Text = job.GetProblem();
            TextBoxSolution.Text = job.GetSolution();
            TextBoxMilage.Text = job.GetMilage().ToString();
            TextBoxCost.Text = job.GetCost().ToString();
            TextBoxRevenue.Text = job.GetRevenue().ToString();
        }

        private void ButtonClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
