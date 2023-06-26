using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlServer.Insert(id.Text.ToString(), name.Text.ToString(), family.Text.ToString());
            id.Text = "";
            name.Text = "";
            family.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            comboBox1.Items.Clear();
            string Path = "Data Source = DESKTOP-7M23CVC\\ABOLFAZL;Initial Catalog = People;Integrated Security = true";
            SqlConnection Connection = new SqlConnection(Path);
            string query = $"select * from Contacts";

            Connection.Open();
            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = reader.GetValue(1) + " " + reader.GetValue(2);
             comboBox1.Items.Add(comboBoxItem);   
                
            }
        }
    }
}
