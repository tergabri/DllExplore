using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllExplore
{
    struct DependancyItem
    {
        public DependancyItem(string Status_,
                              string Module_,
                              string FileTimeStamp_,
                              string LinkTimeStamp_,
                              string FileSize_,
                              string Attr_,
                              string LinkChecksum_,
                              string RealChecksum_,
                              string CPU_,
                              string Subsystem_,
                              string Symbols_,
                              string PreferredBase_,
                              string ActualBase_,
                              string VirtualSize_,
                              string LoadOrder_,
                              string FileVer_,
                              string ProductVer_,
                              string ImageVer_,
                              string LinkerVer_,
                              string OSVer_,
                              string SubsystemVer_)
        {
            this.Status = Status_;
            this.Module = Module_;
            this.FileTimeStamp = FileTimeStamp_;
            this.LinkTimeStamp = LinkTimeStamp_;
            this.FileSize = FileSize_;
            this.Attr = Attr_;
            this.LinkChecksum = LinkChecksum_;
            this.RealChecksum = RealChecksum_;
            this.CPU = CPU_;
            this.Subsystem = Subsystem_;
            this.Symbols = Symbols_;
            this.PreferredBase = PreferredBase_;
            this.ActualBase = ActualBase_;
            this.VirtualSize = VirtualSize_;
            this.LoadOrder = LoadOrder_;
            this.FileVer = FileVer_;
            this.ProductVer=ProductVer_;
            this.ImageVer = ImageVer_;
            this.LinkerVer = LinkerVer_;
            this.OSVer = OSVer_;
            this.SubsystemVer = SubsystemVer_;
        }

        public string Status;
        public string Module;
        public string FileTimeStamp;
        public string LinkTimeStamp;
        public string FileSize;
        public string Attr;
        public string LinkChecksum;
        public string RealChecksum;
        public string CPU;
        public string Subsystem;
        public string Symbols;
        public string PreferredBase;
        public string ActualBase;
        public string VirtualSize;
        public string LoadOrder;
        public string FileVer;
        public string ProductVer;
        public string ImageVer;
        public string LinkerVer;
        public string OSVer;
        public string SubsystemVer;
    }
}
