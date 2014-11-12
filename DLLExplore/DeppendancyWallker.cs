using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace DllExplore
{
    class DeppendancyWallker
    {
        public DeppendancyWallker(string filename_)
        {
            this.filename = filename_;
            dumpDependancies();
            parseDependancies();
        }

        void dumpDependancies()
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo 
                {
                    FileName = "..\\..\\Batch\\Dependancy Walker\\DependancyWalkerBatch.cmd",
                    Arguments = filename + " " + output,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true 
                }
            };
            proc.Start();
        }

        void parseDependancies()
        {
            TextFieldParser parser = new TextFieldParser(output);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                //Processing row
                string[] fields = parser.ReadFields();

                dependancyList.Add(new DependancyItem(fields[0],
                                                      fields[1],
                                                      fields[2],
                                                      fields[3],
                                                      fields[4],
                                                      fields[5],
                                                      fields[6],
                                                      fields[7],
                                                      fields[8],
                                                      fields[9],
                                                      fields[10],
                                                      fields[11],
                                                      fields[12],
                                                      fields[13],
                                                      fields[14],
                                                      fields[15],
                                                      fields[16],
                                                      fields[17],
                                                      fields[18],
                                                      fields[19],
                                                      fields[20]));
            }
            parser.Close();
        }

        public List<DependancyItem> getExports()
        {
            return dependancyList;
        }

        string filename;
        string output = "..\\..\\Batch\\Dependancy Walker\\result2.csv";
        List<DependancyItem> dependancyList = new List<DependancyItem>();
    }
}
