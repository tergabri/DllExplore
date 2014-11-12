using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.ComponentModel;

namespace DllExplore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PropertyChangedEventArgs myVarChangedEventArgs = new PropertyChangedEventArgs("ordinal");
        private DataTable DumpbinDataTable { get; set; }
        public DataView DumpbinDataView { get; set; }

        private DataTable DepWalkerDataTable { get; set; }
        public DataView DepWalkerDataView { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void bOpenFileDumpbin_Click(object sender, RoutedEventArgs e)
        {
            //cleans the existing dataview before filling it
            DumpbinDataTable = new DataTable();
            DumpbinDataTable.Clear();
            DumpbinDataView = new DataView();

            DataContext = null;//to allow the update

            // Create an instance of the open file dialog box.
            Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "DLL Files (.dll)|*.dll|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            // Show open file dialog box
            Nullable<bool> result = openFileDialog1.ShowDialog();

            // Process open file dialog box results 
            if (result == true)
            {
                // Open document 
                Dumpbin myExplore = new Dumpbin(openFileDialog1.FileName);
                DumpbinData myDisplay = new DumpbinData(myExplore);
                DumpbinDataTable = myDisplay.getDataExp();
                DumpbinDataView = DumpbinDataTable.DefaultView;
                // bind the Date to the UI
                DataContext = this;
            }
        }

        private void bOpenFileDepWalker_Click(object sender, RoutedEventArgs e)
        {
            //cleans the existing dataview before filling it
            DepWalkerDataTable = new DataTable();
            DepWalkerDataTable.Clear();
            DepWalkerDataView = new DataView();

            DataContext = null;//to allow the update

            // Create an instance of the open file dialog box.
            Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "DLL Files (.dll)|*.dll|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            // Show open file dialog box
            Nullable<bool> result = openFileDialog1.ShowDialog();

            // Process open file dialog box results 
            if (result == true)
            {
                // Open document 
                DeppendancyWallker myExplore = new DeppendancyWallker(openFileDialog1.FileName);
                DependancyWalkerData myDisplay = new DependancyWalkerData(myExplore);
                DepWalkerDataTable = myDisplay.getDataDep();
                DepWalkerDataView = DepWalkerDataTable.DefaultView;
                //// bind the Date to the UI
                DataContext = this;
            }
        }

    }
}
