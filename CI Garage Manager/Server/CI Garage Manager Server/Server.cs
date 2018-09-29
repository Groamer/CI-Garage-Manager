using CI_Garage_Manager_Server.Controllers;
using CI_Garage_Manager_Server.Views;

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CI_Garage_Manager_Server
{
    static class Server
    {
        [STAThread]
        static void Main()
        {
            Thread serverThread = new Thread(new ThreadStart(AsynchronousSocketListener.StartListening));
            serverThread.Start();

            Thread formThread = new Thread(new ThreadStart(Forms));
            formThread.Start();
        }

        private static void Forms()
        {
            Application.Run(new ControlPanel());
        }
    }

    public class StateObject
    {
        public Socket workSocket = null;
        public const int BufferSize = 1024;
        public byte[] buffer = new byte[BufferSize];
        public StringBuilder sb = new StringBuilder();
    }

    public class AsynchronousSocketListener
    {
        private static CarController carController = new CarController();
        private static JobController jobController = new JobController();

        // Thread signal.  
        public static ManualResetEvent allDone = new ManualResetEvent(false);

        public AsynchronousSocketListener()
        {
        }

        public static void StartListening()
        {
            // Establish the local endpoint for the socket.  
            // The DNS name of the computer  
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 12345);

            // Create a TCP/IP socket.  
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.  
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                while (true)
                {
                    // Set the event to nonsignaled state.
                    allDone.Reset();

                    // Start an asynchronous socket to listen for connections.  
                    Console.WriteLine("Waiting for a connection...");
                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);

                    // Wait until a connection is made before continuing.  
                    allDone.WaitOne();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();

        }

        public static void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.  
            allDone.Set();

            // Get the socket that handles the client request.  
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Create the state object.  
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public static void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the state object and the handler socket  
            // from the asynchronous state object.  
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Read data from the client socket.   
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There  might be more data, so store the data received so far.  
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read   
                // more data.  
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // All the data has been read from the   
                    // client. Display it on the console.  
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);

                    // Process protocol and call methods.
                    string[] protocol = content.Split('|');
                    switch (protocol[0])
                    {
                        case "Connect":
                            Send(handler, "OK");
                            break;

                        case "CarSave":
                            carController.Save();
                            Send(handler, "OK");
                            break;
                        case "CarCreate":
                            carController.Create(protocol[1]);
                            Send(handler, "OK");
                            break;
                        case "CarEdit":
                            carController.Edit(protocol[1], Int32.Parse(protocol[2]));
                            Send(handler, "OK");
                            break;
                        case "CarRemove":
                            carController.Remove(Int32.Parse(protocol[1]));
                            Send(handler, "OK");
                            break;
                        case "CarGet":
                            Send(handler, carController.Get(Int32.Parse(protocol[1]), Int32.Parse(protocol[2])));
                            break;
                        case "CarSearch":
                            Send(handler, carController.Search(protocol[1], Int32.Parse(protocol[2]), Int32.Parse(protocol[3])));
                            break;

                        case "JobSave":
                            jobController.Save();
                            Send(handler, "OK");
                            break;
                        case "JobCreate":
                            jobController.Create(protocol[1]);
                            Send(handler, "OK");
                            break;
                        case "JobEdit":
                            jobController.Edit(protocol[1], Int32.Parse(protocol[2]));
                            Send(handler, "OK");
                            break;
                        case "JobRemove":
                            jobController.Remove(Int32.Parse(protocol[1]));
                            Send(handler, "OK");
                            break;
                        case "JobGet":
                            Send(handler, jobController.Get(Int32.Parse(protocol[1]), Int32.Parse(protocol[2]), Int32.Parse(protocol[3])));
                            break;
                        case "JobGetAll":
                            Send(handler, jobController.GetAll());
                            break;
                        case "JobSearch":
                            Send(handler, jobController.Search(protocol[1], Int32.Parse(protocol[2]), Int32.Parse(protocol[3]), Int32.Parse(protocol[4])));
                            break;
                        case "JobSearchAll":
                            Send(handler, jobController.SearchAll(protocol[1]));
                            break;

                        default:
                            Send(handler, "ERROR");
                            break;
                    }
                }
                else
                {
                    // Not all data received. Get more.  
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        private static void Send(Socket handler, string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);

            // Begin sending the data to the remote device.  
            handler.BeginSend(bytes, 0, data.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
