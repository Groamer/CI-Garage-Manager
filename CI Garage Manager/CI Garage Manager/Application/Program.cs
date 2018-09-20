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
            car1.SetMake("Volkswagen");
            car1.SetModel("Polo 6N");
            car1.SetEngine("1.4L I4 8v");
            car1.SetPlate("PJ-PH-56");
            car1.SetVehicleID("234234324");
            car1.SetYear(1996);

            CarModel car2 = new CarModel();
            car2.SetMake("Mazda");
            car2.SetModel("MX-3 KL-ZE");
            car2.SetEngine("2.5L V6 24v");
            car2.SetPlate("PX-TF-95");
            car2.SetVehicleID("asd34324");
            car2.SetYear(1997);

            CarModel car3 = new CarModel();
            car3.SetMake("Volkswagen");
            car3.SetModel("Polo 6N");
            car3.SetEngine("1.6L I4 8v");
            car3.SetPlate("LZ-BG-53");
            car3.SetVehicleID("assd34324");
            car3.SetYear(1995);


            JobModel job = new JobModel();
            job.SetCarID(4);
            job.SetProblem("TRICKERY PENIS.");

            CarController carController = new CarController();
            JobController jobController = new JobController();

            carController.Create(car1);
            carController.Create(car2);
            carController.Create(car3);
            carController.Search("px-tf-95 mAzDa");

            //carController.Save();
            //jobController.Save();
        }
    }
}
