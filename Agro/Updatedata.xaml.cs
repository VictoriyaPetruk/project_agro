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

namespace Agro
{
    /// <summary>
    /// Логика взаимодействия для Updatedata.xaml
    /// </summary>
    public partial class Updatedata : Window
    {
        public Updatedata()
        {
            InitializeComponent();
        }
        ClassDatabase db = new ClassDatabase();
        public List<Culture> ListCulture = new List<Culture>();
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string d = @"select c.name_c from culture c ";
            db.Execute<Culture>("agriculture.db", d, ref ListCulture);
            for (int i = 0; i < ListCulture.Count; i++)
            {
                {
                    if (!cbculture.Items.Contains(ListCulture[i].Nameculture))
                    {
                        cbculture.Items.Add(ListCulture[i].Nameculture);

                    }

                }

            }
            cbculture.Text = ListCulture[1].Nameculture;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = @"update sort_culture set price=price+((price*10)/100) where id_c=(select id_c from culture where name_c='" + cbculture.Text + "')";
            db.ExecuteNonQuery("agriculture.db", s, 1);
            MessageBox.Show("Ціна оновлена");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Головна_сторінка a = new Головна_сторінка();
            a.Show();
            this.Hide();
        }
    }
}
