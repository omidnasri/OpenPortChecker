using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenPortChecker
{
    public partial class MainView : Form
    {
        private Controller.NetworkController networkController;

        public MainView()
        {
            InitializeComponent();

            networkController = new Controller.NetworkController(this);
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            String message = "Server " + inputServer.Text + " is " + (networkController.pingServer(inputServer.Text) ? "online" : "offline") + ".";
            String title = "Ping result";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            MessageBox.Show(message, title, buttons);
        }

        private void buttonScanPorts_Click(object sender, EventArgs e)
        {
            if (inputMethod.Text.Equals("Single port"))
            {
                String message = "Port " + inputFirstPort.Text + " on " + inputServer.Text + " is " + (networkController.scanSinglePort(inputServer.Text, Convert.ToInt32(inputFirstPort.Text)) ? "open" : "closed") + "!";
                String title = "Scanresult";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, title, buttons);
            }
            else if (inputMethod.Text.Equals("Range"))
            {
                networkController.scanRangeOfPorts(inputServer.Text, Convert.ToInt32(inputFirstPort.Text), Convert.ToInt32(inputLastPort.Text));
            }
            else if (inputMethod.Text.Equals("All ports"))
            {
                networkController.scanRangeOfPorts(inputServer.Text, 1, 65536);
            }

            setProgress(0);
        }

        private void inputServer_TextChanged(object sender, EventArgs e)
        {
            updateForm();
        }

        private void inputMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateForm();
        }

        private void inputFirstPort_TextChanged(object sender, EventArgs e)
        {
            updateForm();
        }

        private void inputLastPort_TextChanged(object sender, EventArgs e)
        {
            updateForm();
        }

        private void updateForm()
        {
            // Main checkers
            if (inputServer.Text.Length > 0)
            {
                buttonPing.Enabled = true;
            }
            else
            {
                buttonPing.Enabled = false;
            }

            // Individual checkers
            if (inputMethod.Text.Equals("Single port"))
            {
                inputFirstPort.Enabled = true;
                inputLastPort.Enabled = false;

                Boolean port = inputFirstPort.Text.Length > 0;
                Boolean portMin, portMax;

                try
                {
                    portMin = Convert.ToInt32(inputFirstPort.Text) > 0;
                }
                catch
                {
                    portMin = false;
                }

                try
                {
                    portMax = Convert.ToInt32(inputFirstPort.Text) <= 65536;
                }
                catch
                {
                    portMax = false;
                }
                    
                if (port && portMin && portMin)
                {
                    buttonScanPorts.Enabled = true;
                }
                else
                {
                    buttonScanPorts.Enabled = false;
                }
            }
            else if (inputMethod.Text.Equals("Range"))
            {
                inputFirstPort.Enabled = true;
                inputLastPort.Enabled = true;

                Boolean firstPort = inputFirstPort.Text.Length > 0;
                Boolean lastPort = inputLastPort.Text.Length > 0;
                Boolean firstPortCheck, lastPortCheck, firstLowerThanLast;

                try
                {
                    firstPortCheck = Convert.ToInt32(inputFirstPort.Text) > 0 && Convert.ToInt32(inputFirstPort.Text) <= 65536;
                }
                catch
                {
                    firstPortCheck = false;
                }

                try
                {
                    lastPortCheck = Convert.ToInt32(inputLastPort.Text) > 0 && Convert.ToInt32(inputLastPort.Text) <= 65536;
                }
                catch
                {
                    lastPortCheck = false;
                }

                try
                {
                    firstLowerThanLast = Convert.ToInt32(inputFirstPort.Text) < Convert.ToInt32(inputLastPort.Text);
                }
                catch
                {
                    firstLowerThanLast = false;
                }

                if (firstPort && lastPort && firstPortCheck && lastPortCheck && firstLowerThanLast)
                {
                    buttonScanPorts.Enabled = true;
                }
                else
                {
                    buttonScanPorts.Enabled = false;
                }
            }
            else if (inputMethod.Text.Equals("All ports"))
            {
                inputFirstPort.Enabled = false;
                inputLastPort.Enabled = false;

                if (inputServer.Text.Length > 0)
                {
                    buttonScanPorts.Enabled = true;
                }
                else
                {
                    buttonScanPorts.Enabled = false;
                }
            }

            // Last checkers
            if (!inputMethod.Text.Equals("Single port") && !inputMethod.Text.Equals("Range") && !inputMethod.Text.Equals("All ports"))
            {
                inputMethod.Text = "Unknown scanmethod!";
                buttonScanPorts.Enabled = false;
            }
        }

        public void setProgress(int progress)
        {
            progressScanning.Value = progress;
        }

        private void progressScanning_Click(object sender, EventArgs e)
        {

        }

        public ProgressBar getMainProgressBar()
        {
            return progressScanning;
        }
    }
}
