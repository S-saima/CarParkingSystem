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
using System.Windows.Shapes;
using System.Data;
namespace demo
{
    /// <summary>
    /// Interaction logic for Parking_Details.xaml
    /// </summary>
    public partial class Parking_Details : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        string connectionString = @"Data Source=ASUS;Initial Catalog=Park;Integrated Security=True";
        public Parking_Details()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM [AllDetails]", con);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    P_Details.ItemsSource = dt.DefaultView;
                    sqlda.Update(dt);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            


        }
    }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager m = new Manager();
            m.Show();
            this.Hide();
        }
    }
}
