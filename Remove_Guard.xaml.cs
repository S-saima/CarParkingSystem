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

namespace demo
{
    /// <summary>
    /// Interaction logic for Remove_Guard.xaml
    /// </summary>
    public partial class Remove_Guard : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public Remove_Guard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager m = new Manager();
            m.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Park;Integrated Security=True");
            try
            {
                con.Open();
               

                    string query = "DELETE FROM [Guard] WHERE Id ='" + RGuard_ID.Text + "' AND Name= '" + RGuard_Name.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                   
                cmd.ExecuteScalar();
                
                MessageBox.Show("Remove Guard Successfully");

                  }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
