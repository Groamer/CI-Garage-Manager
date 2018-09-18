using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI_Garage_Manager.Application.Models
{
    class Job
    {
        private Car car;
        private string problem;
        private string solution;
        private int milage;
        private float cost;
        private float revenue;

        public Car GetCar()
        {
            return this.car;
        }
        public void SetCar(Car car)
        {
            this.car = car;
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
    }
}
