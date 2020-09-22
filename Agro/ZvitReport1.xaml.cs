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
using System.Windows.Shapes;
using FastReport;
using FastReport.Utils;
using FastReport.Data;
using FastReport.Design;
using FastReport.Design.StandardDesigner;

namespace Agro
{
    /// <summary>
    /// Логика взаимодействия для ZvitReport1.xaml
    /// </summary>
    public partial class ZvitReport1 : Window
    {
        public ZvitReport1()
        {
            InitializeComponent();
        }
        FastReport.Preview.PreviewControl prew = new FastReport.Preview.PreviewControl();
        Report report = new Report();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            report.Load(@"C:\Users\Виктория\source\repos\Agro\Agro\bin\Debug\zvit1.frx");
            report.Preview = prew;
            report.Prepare();
            report.ShowPrepared();
            WindowsFormsHost1.Child = prew;
        }
    }
}
