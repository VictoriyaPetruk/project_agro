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
using System.Windows.Threading;
namespace Agro
{
    /// <summary>
    /// Логика взаимодействия для Головна_сторінка.xaml
    /// </summary>
    public partial class Головна_сторінка : Window
    {
        private BitmapImage[] images;
        private int counter = 0;
        public Головна_сторінка()
        {
            InitializeComponent();
            images = new BitmapImage[5];
            images[0] = new BitmapImage(new Uri("/Agro;component/phone1.png", UriKind.Relative));
            images[1] = new BitmapImage(new Uri("/Agro;component/phone2.png", UriKind.Relative));
            images[2] = new BitmapImage(new Uri("/Agro;component/phone3.png", UriKind.Relative));
            images[3] = new BitmapImage(new Uri("/Agro;component/phone4.png", UriKind.Relative));
            images[4] = new BitmapImage(new Uri("/Agro;component/phone5.png", UriKind.Relative));
            DispatcherTimer dT = new DispatcherTimer();
            dT.Interval = new TimeSpan(0, 0, 3);
            dT.Tick += new EventHandler(dT_Tick);
            dT.Start();

        }
        void dT_Tick(object sender, EventArgs e)
        {
            image1.Source = images[counter % images.Length];
            counter++;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Вивід_данних a = new Вивід_данних();
            this.Hide();
            a.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Поставки a = new Поставки();
            this.Hide();
            a.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Звіти a = new Звіти();
            this.Hide();
            a.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Updatedata a = new Updatedata();
            this.Hide();
            a.Show();
        }
    }
}
