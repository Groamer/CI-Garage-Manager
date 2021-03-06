﻿using System;

namespace CI_Garage_Manager.Models
{
    [Serializable]
    public class JobModel
    {
        private int carID;
        private string startDate;
        private string endDate;
        private string problem;
        private string solution;
        private int milage;
        private float cost;
        private float revenue;

        public int GetCarID()
        {
            return carID;
        }
        public void SetCarID(int carID)
        {
            this.carID = carID;
        }

        public string GetStartDate()
        {
            return startDate;
        }
        public void SetStartDate(string startDate)
        {
            this.startDate = startDate;
        }

        public string GetEndDate()
        {
            return endDate;
        }
        public void SetEndDate(string endDate)
        {
            this.endDate = endDate;
        }

        public string GetProblem()
        {
            return problem;
        }
        public void SetProblem(string problem)
        {
            this.problem = problem;
        }

        public string GetSolution()
        {
            return solution;
        }
        public void SetSolution(string solution)
        {
            this.solution = solution;
        }

        public int GetMilage()
        {
            return milage;
        }
        public void SetMilage(int milage)
        {
            this.milage = milage;
        }

        public float GetCost()
        {
            return cost;
        }
        public void SetCost(float cost)
        {
            this.cost = cost;
        }

        public float GetRevenue()
        {
            return cost;
        }
        public void SetRevenue(float revenue)
        {
            this.revenue = revenue;
        }

        override public string ToString()
        {
            return carID.ToString() + "[[JobModel]]" + startDate + "[[JobModel]]" + endDate + "[[JobModel]]" + problem + "[[JobModel]]" + solution + "[[JobModel]]" + milage.ToString() + "[[JobModel]]" + cost.ToString() + "[[JobModel]]" + revenue.ToString();
        }
    }
}