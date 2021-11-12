using System;
using System.Collections.Generic;
using System.Data;
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

namespace demo
{
    /// <summary>
    /// Interaction logic for Guard_Details1.xaml
    /// </summary>
    public partial class Guard_Details1 : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        string connectionString = @"Data Source=ASUS;Initial Catalog=Park;Integrated Security=True";
        public Guard_Details1()
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
                    SqlDataAdapter sqlda = new SqlDataAdapter("SELECT Id,Name,Email,Address,Date_of_Birth,Gender,Branch FROM [Guard]", con);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    GD_Details.ItemsSource = dt.DefaultView;
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

            Admin a = new Admin();
            a.Show();
            this.Hide();

        }
    }
}
