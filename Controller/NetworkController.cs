using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenPortChecker.Controller
{
    class NetworkController
    {
        private MainView mainView;
        private IOController ioController;
        private ProgressBar progressScanning;

        public NetworkController(MainView mainView)
        {
            this.mainView = mainView;
            ioController = new IOController();
            progressScanning = mainView.getMainProgressBar();
        }

        public Boolean pingServer(String server)
        {
            Ping ping = new Ping();

            try
            {
                PingReply pingReply = ping.Send(server);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean scanSinglePort(String server, int port)
        {
            Boolean isOpen;

            try
            {
                TcpClient tcpClient = new TcpClient();
                UdpClient udpClient = new UdpClient();

                tcpClient.Connect(server, port);
                udpClient.Connect(server, port);

                isOpen = true;
            }
            catch
            {
                isOpen = false;
            }

            return isOpen;
        }

        public void scanRangeOfPorts(String server, int startPort, int endPort)
        {
            int portCount = (endPort - startPort) + 1;
            String[] scanResult = new String[portCount];
            double progressPerPort = 100.00 / portCount;
            double currentProgress = 0.0;

            int currentId = 0;
            for (int i = startPort; i <= endPort; i++)
            {
                Boolean isOpen;

                currentProgress += progressPerPort;
                if (currentProgress > 100.0)
                {
                    currentProgress = 100.0;
                }
                
                setProgress((int)currentProgress);

                try
                {
                    TcpClient tcpClient = new TcpClient();
                    UdpClient udpClient = new UdpClient();

                    tcpClient.Connect(server, i);
                    udpClient.Connect(server, i);

                    isOpen = true;
                }
                catch
                {
                    isOpen = false;
                }

                scanResult[currentId++] = "Port " + i + " is " + (isOpen ? "open" : "closed") + "!";
            }

            ioController.writeScanresultsToTextFile(scanResult);
            ioController.openTextFile("Scanresults.txt");
        }

        private void setProgress(int progress)
        {
            progressScanning.Value = progress;
        }
    }
}
