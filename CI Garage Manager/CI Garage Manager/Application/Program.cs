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
            CarModel car1 = new CarModel();
            car1.SetMake("Mazda");
            car1.SetModel("MX-3");

            CarModel car2 = new CarModel();
            car2.SetMake("Volkswagen");
            car2.SetModel("Polo");

            CarModel car3 = new CarModel();
            car3.SetMake("Chrysler");
            car3.SetModel("PT Cruiser GT");

            CarController carController = new CarController();
            carController.CreateCar(car1);
            carController.CreateCar(car2);
            carController.PrintCars();

            Console.WriteLine("HERPDERP EDIT CARS");
            carController.EditCar(car3, 0);
            carController.PrintCars();

            Console.WriteLine("HERPDERP DELETE CARS");
            carController.RemoveCar(0);
            carController.PrintCars();

            //TEST JOB MODEL AND CONTROLLER
            Console.WriteLine("Adding jobs...");

            JobModel job1 = new JobModel();
            job1.SetCarID(0);
            job1.SetProblem("Car does not start. Engine is leaking oil.");

            JobModel job2 = new JobModel();
            job2.SetCarID(1);
            job2.SetProblem("Car is leaking coolant. Third gear does not work.");

            JobController jobController = new JobController();
            jobController.CreateJob(job1);
            jobController.CreateJob(job2);

            jobController.PrintJobs();
        }
    }
}
