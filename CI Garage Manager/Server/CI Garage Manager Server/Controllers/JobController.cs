using CI_Garage_Manager.Models;

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CI_Garage_Manager_Server.Controllers
{
    class JobController
    {
        BinaryFormatter binaryFormatter;

        private List<JobModel> jobs;
        private readonly string path;

        public JobController()
        {
            binaryFormatter = new BinaryFormatter();

            jobs = new List<JobModel>();
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + "\\ComputerInfor\\CI Garage Manager Server";

            Load();
        }

        public void Save()
        {
            Directory.CreateDirectory(path);

            try
            {
                Stream stream = File.OpenWrite(path + "\\Jobs.dat");
                binaryFormatter.Serialize(stream, jobs);
                stream.Flush();
                stream.Close();
                stream.Dispose();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void Load()
        {
            try
            {
                FileStream fileStream = File.Open(path + "\\Jobs.dat", FileMode.Open);
                object jobList = binaryFormatter.Deserialize(fileStream);
                jobs = (List<JobModel>)jobList;
                fileStream.Flush();
                fileStream.Close();
                fileStream.Dispose();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        public void Create(string jobString)
        {
            JobModel job = new JobModel();
            string[] jobDetails = jobString.Split('\n');

            job.SetCarID(Int32.Parse(jobDetails[0]));
            job.SetStartDate(jobDetails[1]);
            job.SetEndDate(jobDetails[2]);
            job.SetProblem(jobDetails[3]);
            job.SetSolution(jobDetails[4]);
            job.SetMilage(Int32.Parse(jobDetails[5]));
            job.SetCost(float.Parse(jobDetails[6]));
            job.SetRevenue(float.Parse(jobDetails[7]));

            jobs.Add(job);
        }

        public void Edit(string jobString, int ID)
        {
            JobModel job = new JobModel();
            string[] jobDetails = jobString.Split('\n');

            job.SetCarID(Int32.Parse(jobDetails[0]));
            job.SetStartDate(jobDetails[1]);
            job.SetEndDate(jobDetails[2]);
            job.SetProblem(jobDetails[3]);
            job.SetSolution(jobDetails[4]);
            job.SetMilage(Int32.Parse(jobDetails[5]));
            job.SetCost(float.Parse(jobDetails[6]));
            job.SetRevenue(float.Parse(jobDetails[7]));

            try
            {
                jobs[ID] = job;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        public void Remove(int ID)
        {
            try
            {
                jobs.RemoveAt(ID);
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        public string Get(int carID, int page, int shownItems)
        {
            List<JobModel> jobSelection = new List<JobModel>();
            string jobList = "JobList";
            int firstItem = (page * shownItems) - shownItems;
            int lastItem = firstItem + shownItems;

            foreach (JobModel job in jobs)
            {
                if (job.GetCarID() == carID)
                {
                    jobSelection.Add(job);
                }
            }

            for (int i = firstItem; i < lastItem; i ++)
            {
                if(i + 1 > jobSelection.Count)
                {
                    break;
                }
                else
                {
                    jobList += "|" + jobSelection[i].ToString();
                }
            }

            return jobList;
        }

        public string GetAll()
        {
            string jobList = "JobList";

            foreach(JobModel job in jobs)
            {
                jobList += "|" + job.ToString();
            }

            return jobList;
        }

        public string Search(string input, int carID, int page, int shownItems)
        {
            List<JobModel> jobSelection = new List<JobModel>();
            string[] terms = input.Split(' ');
            string jobList = "JobList";
            int firstItem = (page * shownItems) - shownItems;
            int lastItem = firstItem + shownItems;

            foreach (JobModel job in jobs)
            {
                if (job.GetCarID() == carID)
                {
                    jobSelection.Add(job);
                }
            }

            foreach (JobModel job in jobSelection)
            {
                Boolean hit = true;

                foreach (string term in terms)
                {
                    if (!job.ToString().ToLowerInvariant().Contains(term.ToLowerInvariant()))
                    {
                        hit = false;
                    }
                }

                if (hit)
                {
                    jobList += "|" + job.ToString();
                }
            }

            return jobList;
        }

        public string SearchAll(string input)
        {
            string[] terms = input.Split(' ');
            string jobList = "JobList";

            foreach (JobModel job in jobs)
            {
                Boolean hit = true;

                foreach (string term in terms)
                {
                    if (!job.ToString().ToLowerInvariant().Contains(term.ToLowerInvariant()))
                    {
                        hit = false;
                    }
                }

                if (hit)
                {
                    jobList += "|" + job.ToString();
                }
            }

            return jobList;
        }

        public void PrintJobs()
        {
            foreach (JobModel job in jobs)
            {
                Console.WriteLine(job.ToString());
            }
        }
    }
}
