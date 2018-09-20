using CI_Garage_Manager.Application.Models;
using CI_Garage_Manager.Application.Controllers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CI_Garage_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //TEST CAR MODEL AND CONTROLLER
            CarModel car = new CarModel();
            car.SetMake("Volkswagen");
            car.SetModel("Polo 6N");

            JobModel job = new JobModel();
            job.SetCarID(4);
            job.SetProblem("TRICKERY PENIS.");

            CarController carController = new CarController();
            JobController jobController = new JobController();

            /*for (int i = 0; i < 1000000; i ++)
            {
                carController.Create(car);
                
                jobController.Create(job);
            }*/

            carController.Save();

            jobController.Save();
        }
    }
}
