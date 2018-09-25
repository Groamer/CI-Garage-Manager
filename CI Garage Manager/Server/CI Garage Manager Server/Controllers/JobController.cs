using CI_Garage_Manager_Server.Models;

using System;
using System.Collections.Generic;
using System.Globalization;
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
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + "\\ComputerInfor\\CI Garage Manager";

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
            job.SetCost(float.Parse(jobDetails[6], CultureInfo.InvariantCulture.NumberFormat));
            job.SetRevenue(float.Parse(jobDetails[7], CultureInfo.InvariantCulture.NumberFormat));

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
            job.SetCost(float.Parse(jobDetails[6], CultureInfo.InvariantCulture.NumberFormat));
            job.SetRevenue(float.Parse(jobDetails[7], CultureInfo.InvariantCulture.NumberFormat));

            jobs[ID] = job;
        }

        public void Remove(int ID)
        {
            jobs.RemoveAt(ID);
        }

        public byte[] GetJobs(int carID, int page, int shownItems)
        {
            MemoryStream memoryStream = new MemoryStream();
            List<JobModel> jobList = new List<JobModel>();
            List<JobModel> jobSelection = new List<JobModel>();
            int firstItem = (page * shownItems) - shownItems;
            int lastItem = firstItem + shownItems;

            foreach (JobModel job in jobs)
            {
                if (job.GetCarID() == carID)
                {
                    jobList.Add(job);
                }
            }

            //TEMP TEST
            Console.WriteLine("Amount of jobs for given car: " + jobList.Count);

            for (int i = firstItem; i < lastItem; i ++)
            {
                if(i + 1 > jobList.Count)
                {
                    //TEMP TEST
                    Console.WriteLine("Out of bounds");

                    break;
                }
                else
                {
                    jobSelection.Add(jobList[i]);
                }
            }

            binaryFormatter.Serialize(memoryStream, jobSelection);
            memoryStream.Flush();
            memoryStream.Close();
            memoryStream.Dispose();

            return memoryStream.ToArray();
        }

        public byte[] GetAllJobs()
        {
            MemoryStream memoryStream = new MemoryStream();

            binaryFormatter.Serialize(memoryStream, jobs);
            memoryStream.Flush();
            memoryStream.Close();
            memoryStream.Dispose();

            return memoryStream.ToArray();
        }

        public byte[] Search(string input)
        {
            MemoryStream memoryStream = new MemoryStream();
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

            binaryFormatter.Serialize(memoryStream, jobList);
            memoryStream.Flush();
            memoryStream.Close();
            memoryStream.Dispose();

            return memoryStream.ToArray();
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
