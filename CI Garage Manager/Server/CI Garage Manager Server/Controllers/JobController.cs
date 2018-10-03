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
            string[] jobDetails = jobString.Split(new string[] {"[[JobModel]]"}, StringSplitOptions.None);

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

        public void Edit(string jobStringNew, string jobStringOld)
        {
            JobModel job = new JobModel();
            string[] jobDetails = jobStringNew.Split(new string[] { "[[JobModel]]" }, StringSplitOptions.None);

            job.SetCarID(Int32.Parse(jobDetails[0]));
            job.SetStartDate(jobDetails[1]);
            job.SetEndDate(jobDetails[2]);
            job.SetProblem(jobDetails[3]);
            job.SetSolution(jobDetails[4]);
            job.SetMilage(Int32.Parse(jobDetails[5]));
            job.SetCost(float.Parse(jobDetails[6]));
            job.SetRevenue(float.Parse(jobDetails[7]));

            for (int i = 0; i < jobs.Count; i++)
            {
                if (jobs[i].ToString() == jobStringOld)
                {
                    jobs[i] = job;
                }
            }
        }

        public void Remove(string jobString)
        {
            for (int i = 0; i < jobs.Count; i++)
            {
                if (jobs[i].ToString() == jobString)
                {
                    jobs.RemoveAt(i);
                    break;
                }
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

        public string Search(string input, int carID, int page, int shownItems)
        {
            List<JobModel> jobSelection = new List<JobModel>();
            List<JobModel> jobList = new List<JobModel>();
            string[] terms = input.Split(' ');
            string jobString = "JobList";
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
                string search = job.ToString().Replace("[[JobModel]]", " ");
                Boolean hit = true;

                foreach (string term in terms)
                {
                    if (!search.ToLowerInvariant().Contains(term.ToLowerInvariant()))
                    {
                        hit = false;
                    }
                }

                if (hit)
                {
                    jobList.Add(job);
                }
            }

            for (int i = firstItem; i < lastItem; i++)
            {
                if (i + 1 > jobList.Count)
                {
                    break;
                }
                else
                {
                    jobString += "|" + jobList[i].ToString();
                }
            }

            return jobString;
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
