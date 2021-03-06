﻿using CI_Garage_Manager.Controllers;

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CI_Garage_Manager.Views
{
    public partial class Connect : Form
    {
        Client client;

        public Connect()
        {
            InitializeComponent();

            client = new Client();
            AddressText.Text = client.getAddress();
            PortText.Text = client.getPort().ToString();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (AddressText.Text == "" || PortText.Text == "")
            {
                MessageBox.Show("Please fill in a server address and a port number to connect to the server.",
                    "Missing Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string address = AddressText.Text;
                int port = Int32.Parse(PortText.Text);

                if (client.ConnectClient(address, port))
                {
                    Hide();
                    Cars cars = new Cars();
                    cars.FormClosed += (s, args) => Close();
                    cars.Show();
                }
                else
                {
                    MessageBox.Show("Could not connect to the specified server address and port number.",
                        "Connection Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void PortText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PortText.Text != "")
                {
                    Int32.Parse(PortText.Text);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Please fill in numbers only.",
                    "Wrong Value", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                PortText.Text = "";
                Console.WriteLine(error);
            }
        }

        private void ToolStripMenuInformation_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.ShowDialog();
        }

        private void ToolStripMenuComputerInfor_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.computerinfor.nl");
        }
    }
}
