using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllExplore
{
    class ExportItem
    {
        public ExportItem(string ordinal_, string hint_, string RVA_, string name_)
        {
            ordinal = ordinal_;
            hint = hint_;
            RVA = RVA_;
            name = name_;
        }

        public string ordinal;
        public string hint;
        public string RVA;
        public string name;
    }
}
