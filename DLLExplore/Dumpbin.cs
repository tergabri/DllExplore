using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DllExplore
{
    class Dumpbin
    {
        public
            Dumpbin(string filename)
        {
            this.filename = filename;
            dumpExports();
            parseExports();
        }

        void dumpExports()
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "..\\..\\Batch\\DumpbinPath.cmd",
                    Arguments = logName + " " + filename,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                Console.WriteLine(line);
                // do something with line
            }
        }

        void parseExports()
        {
            string[] lines = System.IO.File.ReadAllLines(logName);

            const int firstFunctionLine = 19;
            for (int i = firstFunctionLine; i < lines.Count(); ++i)
            {
                if (lines[i] == "")
                    break;

                string[] funcDetails = lines[i].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                exportList.Add(new ExportItem(funcDetails[0],
                                              funcDetails[1],
                                              funcDetails[2],
                                              funcDetails[3]));
            }
        }

        public List<ExportItem> getExports()
        {
            return exportList;
        }

        string filename;
        string logName = "results.csv";
        List<ExportItem> exportList = new List<ExportItem>();

    }
}
