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
    /// Логика взаимодействия для Zvitreport2.xaml
    /// </summary>
    public partial class Zvitreport2 : Window
    {
        public Zvitreport2()
        {
            InitializeComponent();
        }
        FastReport.Preview.PreviewControl prew = new FastReport.Preview.PreviewControl();
        Report report = new Report();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            report.Load(@"C:\Users\Виктория\source\repos\Agro\Agro\bin\Debug\zvit2.frx");
            report.Preview = prew;
            report.Prepare();
            report.ShowPrepared();
            WindowsFormsHost2.Child = prew;
        }
    }
}
