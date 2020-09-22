using DevComponents.Editors.DateTimeAdv;
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
    /// Логика взаимодействия для Поставки.xaml
    /// </summary>
    public partial class Поставки : Window
    {
        public Поставки()
        {
            InitializeComponent();
            grbox.IsEnabled = false;
            cmbsort.IsEnabled = false;
            txtmassa.IsEnabled = false;
            txtprice.IsEnabled = false;
            date1.SelectedDateFormat = DatePickerFormat.Short;
            txtbsum.IsEnabled = false;
            txtder.IsEnabled = false;
            // date1.SelectedDateFormat=("yyyy-MM-dd");
            //  date1.CustomFormat = "yyyy-MM-dd";
        }  
        ClassDatabase db = new ClassDatabase();
        public List<CultureSort> List1 = new List<CultureSort>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {

                //   date1.SelectedDate = Convert.ToDateTime(date1.SelectedDate.Value.ToString("yyyy-MM-dd"));
                // date1.SelectedDate.Value.ToString("dd-MMM-yyyy");
                DateTime date = new DateTime();
                string dater = date.ToShortDateString();
            date1.SelectedDateFormat = DatePickerFormat.Short;
            dater = Convert.ToDateTime(date1.Text).ToString("yyyy-MM-dd");
            
            string a=@"Insert into delivery(date_p,manager) values('"+Convert.ToString(dater)+"','"+txtpib.Text+"')";
            db.ExecuteNonQuery("agriculture.db", a, 1);
            MessageBox.Show("Поставка зареєстрована. Додайте товари до неї.");
            grbox.IsEnabled = true;
            cmbsort.IsEnabled = true;
            txtmassa.IsEnabled = true;

        }
        double sum = 0;
        
   
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {   
            string a = @"Insert into delivery_cultures(id_d,weight_d,id_sc1,sum_der) values((select max(id_d) from delivery)," + Convert.ToDouble(txtmassa.Text)+ ",(select id_sc1 from sort_culture where id_c=(select id_c from culture where name_c='"+cmbculture.Text+ "') and id_s=(select id_s from sort where name_s='" + cmbsort.Text + "')),"+Convert.ToDouble(txtder.Text)+")";
            db.ExecuteNonQuery("agriculture.db", a, 1);
            MessageBox.Show("Товар додан до поставки.");
            sum = sum + Convert.ToDouble(txtprice.Text) + Convert.ToDouble(txtder.Text);
            txtbsum.Text =Convert.ToString(sum) ;
          
           // txtder.Text= Convert.ToString()
            txtprice.Text = "0";
            txtder.Text = "0";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            string a  = @"select c.name_c, s.name_s,cs.price, cs.width_z,c.yield_avr,cr.yield from culture c natural join sort_culture cs natural join sort s natural join crop_culture cr";
            db.Execute<CultureSort>("agriculture.db", a, ref List1);
            for (int i = 0; i < List1.Count; i++)
            {
                {
                    if (!cmbsort.Items.Contains(List1[i].Sort))
                    {
                        cmbsort.Items.Add(List1[i].Sort);

                    }

                }

            }
            cmbsort.Text = List1[1].Sort;

            for (int i = 0; i < List1.Count; i++)
            {
                {
                    if (!cmbculture.Items.Contains(List1[i].Nameculture))
                    {
                        cmbculture.Items.Add(List1[i].Nameculture);

                    }

                }

            }
            cmbculture.Text = List1[1].Nameculture;
        }
        bool f = true;
        bool t = false;
        private void Txtmassa_TextChanged(object sender, TextChangedEventArgs e)
        {
            f = true;
            t = false;
            if (txtmassa.Text == "")
            { }
          
            
            else
            {
                try { Convert.ToDouble(txtmassa.Text); }
                catch (Exception) { MessageBox.Show("Ви ввели невірну масу.","Помилка", MessageBoxButton.OK); txtmassa.Text = ""; return; }

                if (cmbculture.Text == "" || cmbsort.Text == "")
                {
                    MessageBox.Show("Виберіть культуру та сорт");


                }

                else if (f == true)
                {
                    for (int j = 0; j < List1.Count; j++)
                    {
                        if (cmbculture.Text == List1[j].Nameculture && cmbsort.Text == List1[j].Sort)
                        {
                            t = true;break;
                        }
                        
                    }

                }

                 if (t==true)
                {    for (int i = 0; i < List1.Count; i++)
                    {


                        if (cmbculture.Text == List1[i].Nameculture && cmbsort.Text == List1[i].Sort)
                        {
                            txtprice.Text = Convert.ToString(Convert.ToDouble(txtmassa.Text) * List1[i].Price);
                            if((List1[i].Yeild_av*115)/100>=List1[i].Yeild && List1[i].Sort=="вищий" && Convert.ToDouble(txtmassa.Text)>=List1[i].Width)
                            {
                                txtder.Text = Convert.ToString((Convert.ToDouble(txtprice.Text) * 5) / 100);
                            }
                            break;
                        }

                    }
                }
                else { MessageBox.Show("такої культури такого сорту не було замовлено");
                    txtprice.Text = "";
                    txtmassa.Text = "";
                 }
               
                    
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Головна_сторінка a = new Головна_сторінка();
            a.Show();
            this.Hide();
        }

        private void Date1_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
       
        }

        private void Date1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (date1.SelectedDate > DateTime.Today)
            {
                MessageBox.Show("Ви не можете вибрати дату більше сьогодні");
                date1.SelectedDate = DateTime.Today;
            }
        }
    }
}
