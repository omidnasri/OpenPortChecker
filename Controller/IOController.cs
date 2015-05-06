using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPortChecker.Controller
{
    class IOController
    {
        public void writeScanresultsToTextFile(String[] results)
        {
            StreamWriter writer = new StreamWriter("Scanresults.txt");
            
            foreach (String line in results) {
                writer.WriteLine(line);
            }

            writer.Close();
        }

        public void openTextFile(String textfilePath)
        {
            Process.Start("notepad.exe", textfilePath);
        }
    }
}
