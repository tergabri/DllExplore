using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DllExplore
{
    class DumpbinData
    {
        public DumpbinData(Dumpbin dump)
        {
            // Create two DataTable instances.
            dataExp = new DataTable("exports");
            //colums
            dataExp.Columns.Add("ordinal");
            dataExp.Columns.Add("hint");
            dataExp.Columns.Add("RVA");
            dataExp.Columns.Add("name");

            List<ExportItem> exports = dump.getExports();

            //rows
            foreach (ExportItem element in exports)
            {
                dataExp.Rows.Add(element.ordinal, element.hint, element.RVA, element.name);
            }
        }

        public DataTable getDataExp()
        {
            return dataExp;
        }

        DataTable dataExp;

    }
}
