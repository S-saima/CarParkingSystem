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
using System.Data;
using System.Data.SqlClient;

namespace demo
{
    /// <summary>
    /// Interaction logic for M_Details.xaml
    /// </summary>
    public partial class M_Details : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        string connectionString = @"Data Source=ASUS;Initial Catalog=Park;Integrated Security=True";
        public M_Details()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter("SELECT Id,Name,Email,Address,Date_of_Birth,Gender,Branch FROM [M_Table]", con);
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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }
    }
}
