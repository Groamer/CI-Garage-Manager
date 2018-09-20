using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI_Garage_Manager.Application.Models
{
    class JobModel
    {
        private int carID;
        private string problem;
        private string solution;
        private int milage;
        private float cost;
        private float revenue;

        public int GetCarID()
        {
            return this.carID;
        }
        public void SetCarID(int carID)
        {
            this.carID = carID;
        }

        public string GetProblem()
        {
            return this.problem;
        }
        public void SetProblem(string problem)
        {
            this.problem = problem;
        }

        public string GetSolution()
        {
            return this.solution;
        }
        public void SetSolution(string solution)
        {
            this.solution = solution;
        }

        public int GetMilage()
        {
            return this.milage;
        }
        public void SetMilage(int milage)
        {
            this.milage = milage;
        }

        public float GetCost()
        {
            return this.cost;
        }
        public void SetCost(float cost)
        {
            this.cost = cost;
        }

        public float GetRevenue()
        {
            return this.cost;
        }
        public void SetRevenue(float revenue)
        {
            this.revenue = revenue;
        }

        public void PrintJob()
        {
            Console.WriteLine("Car ID: " + this.carID + "\nProblem: " + this.problem + "\n");
        }
    }
}