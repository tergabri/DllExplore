using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllExplore
{
    class DependancyWalkerData
    {
        public DependancyWalkerData(DeppendancyWallker data)
        {
            // Create two DataTable instances.
            dataDep = new DataTable("dependancies");
            //colums
            string[] columns = new string[] { "Status","Module","File Time Stamp","Link Time Stamp","File Size","Attr.","Link Checksum","Real Checksum","CPU","Subsystem","Symbols","Preferred Base","Actual Base","Virtual Size","Load Order","File Ver","Product Ver","Image Ver","Linker Ver","OS Ver","Subsystem Ver" };

            foreach (string col in columns)
            {
                dataDep.Columns.Add(col);
            }

            List<DependancyItem> exports = data.getExports();

            //rows
            foreach (DependancyItem element in exports)
            {
                dataDep.Rows.Add(element.Status, 
                                 element.Module, 
                                 element.FileTimeStamp, 
                                 element.LinkTimeStamp,
                                 element.FileSize,
                                 element.Attr,
                                 element.LinkChecksum,
                                 element.RealChecksum,
                                 element.CPU,
                                 element.Subsystem,
                                 element.Symbols,
                                 element.PreferredBase,
                                 element.ActualBase,
                                 element.VirtualSize,
                                 element.LoadOrder,
                                 element.FileVer,
                                 element.ProductVer,
                                 element.ImageVer,
                                 element.LinkerVer,
                                 element.OSVer,
                                 element.SubsystemVer);
            }
        }

        public DataTable getDataDep()
        {
            int a = dataDep.Rows.Count;
            return dataDep;
        }

        DataTable dataDep;
    }
}
