﻿using CI_Garage_Manager.Views;

using System;
using System.Windows.Forms;

namespace CI_Garage_Manager
{
    class Program
    {
        [STAThread]
        private static void Main()
        {
            Connect connect = new Connect();
            Application.Run(connect);
        }
    }
}