using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScreenEdge {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            double width = SystemParameters.PrimaryScreenWidth;
            this.Width = width;
            this.Left = 0;
            this.Top = 0;
            MouseEnter += MainWindow_MouseEnter;
        }


        private void MainWindow_MouseEnter(object sender, MouseEventArgs e) {
            string shellGUID = "{3080F90E-D7AD-11D9-BD98-0000947B0257}";
            ProcessStartInfo startinfo = new ProcessStartInfo() {
                FileName = "explorer",
                Arguments = $"shell:::{shellGUID}",
                UseShellExecute = true
            };
            Process.Start(startinfo);
        }
    }
}