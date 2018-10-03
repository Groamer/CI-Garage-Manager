using CI_Garage_Manager.Models;

using System;
using System.Collections.Generic;
using System.Linq;

namespace CI_Garage_Manager.Controllers
{
    public class JobsController
    {
        public JobsController()
        {

        }

        public List<JobModel> GetJobs(int carID, int page, int shownItems)
        {
            Client client = new Client();
            return ExtractJobs(client.SendCommand("JobGet|" + carID.ToString() + "|" + page.ToString() + "|" + shownItems.ToString()));
        }

        public List<JobModel> SearchJob(string input, int carID, int page, int shownItems)
        {
            Client client = new Client();
            return ExtractJobs(client.SendCommand("JobSearch|" + input + "|" + carID.ToString() + "|" + page.ToString() + "|" + shownItems.ToString()));
        }

        public void CreateJob(JobModel job)
        {
            Client client = new Client();
            Console.WriteLine(client.SendCommand("JobCreate|" + job.ToString()));
        }

        public void EditJob(JobModel jobNew, JobModel jobOld)
        {
            Client client = new Client();
            Console.WriteLine(client.SendCommand("JobEdit|" + jobNew.ToString() + "|" + jobOld.ToString()));
        }

        public void RemoveJob(JobModel job)
        {
            Client client = new Client();
            Console.WriteLine(client.SendCommand("JobRemove|" + job.ToString()));
        }

        public void SaveJobs()
        {
            Client client = new Client();
            Console.WriteLine(client.SendCommand("JobSave"));
        }

        private List<JobModel> ExtractJobs(string data)
        {
            List<JobModel> jobList = new List<JobModel>();
            string[] protocol = data.Split('|');

            if (protocol[0] == "JobList")
            {
                for (int i = 1; i < protocol.Count(); i++)
                {
                    JobModel job = new JobModel();
                    string[] jobString = protocol[i].Split(new string[] { "[[JobModel]]" }, StringSplitOptions.None);

                    job.SetCarID(Int32.Parse(jobString[0]));
                    job.SetStartDate(jobString[1]);
                    job.SetEndDate(jobString[2]);
                    job.SetProblem(jobString[3]);
                    job.SetSolution(jobString[4]);
                    job.SetMilage(Int32.Parse(jobString[5]));
                    job.SetCost(float.Parse(jobString[6]));
                    job.SetRevenue(float.Parse(jobString[7]));

                    jobList.Add(job);
                }
            }

            return jobList;
        }
    }
}
