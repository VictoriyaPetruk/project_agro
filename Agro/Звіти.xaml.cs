using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Agro
{
    /// <summary>
    /// Логика взаимодействия для Звіти.xaml
    /// </summary>
    public partial class Звіти : Window
    {
        public Звіти()
        {
            InitializeComponent();
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
        }
        public List<Zvit1> ListZvit1 = new List<Zvit1>();
        public List<Zvit2> ListZvit2 = new List<Zvit2>();
        public ObservableCollection<Zvit1> coll1 = new ObservableCollection<Zvit1>();
        public ObservableCollection<Zvit2> coll2 = new ObservableCollection<Zvit2>();
        ClassDatabase db = new ClassDatabase();
        void OnLoad(object sender, RoutedEventArgs e)
        {
            Load_Data();
        }
        public void Load_Data()
        {
            string a = @"select c.name_c, s.name_s,sc.width_z, d.weight_d,( d.weight_d-sc.width_z) from culture c natural join sort_culture sc natural join delivery_cultures  d natural join sort s  ";
           string b = @"select d.id_d, dc.date_p,c.name_c, d.weight_d from culture c natural join sort_culture sc natural join delivery_cultures  d natural join delivery dc";
            db.Execute<Zvit1>("agriculture.db", a, ref ListZvit1);
           db.Execute<Zvit2>("agriculture.db", b, ref ListZvit2);
            

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            coll1.Clear();

            grid2.ItemsSource = null;
            for (int i = 0; i < ListZvit1.Count; i++)
            { coll1.Add(ListZvit1[i]); }
            grid2.ItemsSource = coll1;
            grid2.Columns[0].Header = "Культура";
            grid2.Columns[1].Header = "Сорт";
            grid2.Columns[2].Header = "Маса замовлена";
            grid2.Columns[3].Header = "Маса продана";
            grid2.Columns[4].Header = "Різниця мас";
            grid2.Items.Refresh();
            btn1.IsEnabled = true;
            btn2.IsEnabled = false;
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            coll2.Clear();

            grid2.ItemsSource = null;
            for (int i = 0; i < ListZvit2.Count; i++)
            { coll2.Add(ListZvit2[i]); }
            grid2.ItemsSource = coll2;
            grid2.Columns[0].Header = "Номер поставки";
            grid2.Columns[1].Header = "Дата";
            grid2.Columns[2].Header = "Культура";
            grid2.Columns[3].Header = "Маса поставки";
          
            grid2.Items.Refresh();
            btn2.IsEnabled = true;
            btn1.IsEnabled = false;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ClassSerialiaze.SerialiazeToXml<List<Zvit1>>(ref ListZvit1, "datazvit.xml");
            ZvitReport1 a = new ZvitReport1();
            a.ShowDialog();
        }


        private void Btn2_Click_1(object sender, RoutedEventArgs e)
        {
            ClassSerialiaze.SerialiazeToXml<List<Zvit2>>(ref ListZvit2, "datazvit2.xml");
            Zvitreport2 a = new Zvitreport2();
            a.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Головна_сторінка a = new Головна_сторінка();
            a.Show();
            this.Hide();
        }
    }
}
