using CI_Garage_Manager.Application.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI_Garage_Manager.Application.Controllers
{
    class JobController
    {
        private List<JobModel> jobs;

        public JobController()
        {
            jobs = new List<JobModel>();
        }

        public void LoadJobs()
        {

        }

        public void CreateJob(JobModel job)
        {
            jobs.Add(job);
        }

        public void EditJob(JobModel job, int ID)
        {
            jobs[ID] = job;
        }

        public void RemoveJob(int ID)
        {
            jobs.RemoveAt(ID);
        }

        public void PrintJobs()
        {
            foreach (JobModel job in jobs)
            {
                job.PrintJob();
            }
        }
    }
}
