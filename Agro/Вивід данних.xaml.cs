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
    /// Логика взаимодействия для Вивід_данних.xaml
    /// </summary>
    public partial class Вивід_данних : Window
    {
        public Вивід_данних()
        {
            InitializeComponent();
           
           
        }
        public List<Output1> ListOutput1 = new List<Output1>();
        public List<Output2> ListOutput2 = new List<Output2>();
        public List<Output3> ListOutput3 = new List<Output3>();
        public List<Output4> ListOutput4 = new List<Output4>();
        public ObservableCollection<Output1> coll = new ObservableCollection<Output1>();
        public ObservableCollection<Output2> coll2 = new ObservableCollection<Output2>();
        public ObservableCollection<Output3> coll3 = new ObservableCollection<Output3>();
        public ObservableCollection<Output4> coll4 = new ObservableCollection<Output4>();
        ClassDatabase db = new ClassDatabase();
        public void Load_Data()
        {
            string a = @"select l.number, c.name_c, s.name_s,r.width_y from culture c natural join sort_culture sr natural join crop_culture  r natural join sort s natural join land l ";
            string b = @"select c.name_c, s.name_s, year(r.data_c) from culture c natural join sort_culture sr natural join sort s natural join crop_culture r where year(r.data_c)!=Year(curdate()) or sr.id_sc1!=r.id_sc1  ";
            string c = @"select c.name_c,s.name_s,count(dc.id_sc1), (p.price*count(dc.id_sc1)) from culture c natural join sort_culture p natural join sort s natural join delivery_cultures dc  where dc.id_sc1=p.id_sc1 group by s.name_s;";
            string d = @"select c.name_c,sum(r.width_y) from culture c natural join sort_culture sr natural join crop_culture  r group by 1 order by 2 desc";
            db.Execute<Output1>("agriculture.db", a, ref ListOutput1);
            db.Execute<Output2>("agriculture.db", b, ref ListOutput2);
            db.Execute<Output3>("agriculture.db", c, ref ListOutput3);
            db.Execute<Output4>("agriculture.db", d, ref ListOutput4);
            
        }
       
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            coll.Clear();
           
            grid1.ItemsSource = null;
            for (int i = 0; i < ListOutput1.Count; i++)
            { coll.Add(ListOutput1[i]); }
        grid1.ItemsSource = coll;
            grid1.Columns[0].Header = "Номер поля";
            grid1.Columns[1].Header = "Культури";
            grid1.Columns[2].Header = "Сорт";
            grid1.Columns[3].Header = "Маса врожая";
            grid1.Items.Refresh();
       
        }

        void OnLoad(object sender, RoutedEventArgs e)
        {
            Load_Data();
        }

        private void Grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            coll2.Clear();

            grid1.ItemsSource = null;
            for (int i = 0; i < ListOutput2.Count; i++)
            { coll2.Add(ListOutput2[i]); }


            grid1.ItemsSource = coll2;
            grid1.Columns[0].Header = "Культури";
            grid1.Columns[1].Header = "Сорт";
            grid1.Columns[2].Header = "Рік";
            grid1.Items.Refresh();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            coll3.Clear();

            grid1.ItemsSource = null;
            for (int i = 0; i < ListOutput3.Count; i++)
            { coll3.Add(ListOutput3[i]); }


            grid1.ItemsSource = coll3;
            grid1.Columns[0].Header = "Культури";
            grid1.Columns[1].Header = "Cорт";
            grid1.Columns[2].Header = "Кількість";
            grid1.Columns[3].Header = "Вартість";
            grid1.Items.Refresh();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            coll4.Clear();

            grid1.ItemsSource = null;
            for (int i = 0; i < ListOutput4.Count; i++)
            { coll4.Add(ListOutput4[i]); }


            grid1.ItemsSource = coll4;
            grid1.Columns[0].Header = "Культура";
            grid1.Columns[1].Header = "Маса врожаю";
            
            grid1.Items.Refresh();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Головна_сторінка a = new Головна_сторінка();
            a.Show();
            this.Hide();
        }
    }
}
