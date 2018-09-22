using CI_Garage_Manager.Application.Models;

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CI_Garage_Manager.Application.Controllers
{
    class JobController
    {
        private List<JobModel> jobs;
        private readonly string path;

        public JobController()
        {
            jobs = new List<JobModel>();
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + "\\ComputerInfor\\CI Garage Manager";

            Load();
        }

        public void Save()
        {
            Directory.CreateDirectory(path);

            try
            {
                Stream stream = File.OpenWrite(path + "\\Jobs.dat");
                BinaryFormatter binaryFormatter = new BinaryFormatter();
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

        public void Load()
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream = File.Open(path + "\\Jobs.dat", FileMode.Open);
                object jobList = binaryFormatter.Deserialize(fileStream);
                jobs = (List<JobModel>)jobList;
                fileStream.Flush();
                fileStream.Close();
                fileStream.Dispose();
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        public void Create(JobModel job)
        {
            jobs.Add(job);
        }

        public void Edit(JobModel job, int ID)
        {
            jobs[ID] = job;
        }

        public void Remove(int ID)
        {
            jobs.RemoveAt(ID);
        }

        public List<JobModel> GetJobs(int carID)
        {
            List<JobModel> jobList = new List<JobModel>();
            foreach(JobModel job in jobs)
            {
                if(job.GetCarID() == carID)
                {
                    jobList.Add(job);
                }
            }

            return jobList;
        }

        public List<JobModel> GetAllJobs()
        {
            return jobs;
        }

        public List<JobModel> Search(string input)
        {
            List<JobModel> jobList = new List<JobModel>();
            string[] terms = input.Split(' ');

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
                    jobList.Add(job);
                }
            }

            return jobList;
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
