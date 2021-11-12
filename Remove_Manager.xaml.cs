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
    /// Interaction logic for Remove_Manager.xaml
    /// </summary>
    public partial class Remove_Manager : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public Remove_Manager()
        {
            InitializeComponent();
        }

        private void Manager_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Park;Integrated Security=True");
            try
            {
                con.Open();


                string query = "DELETE FROM [M_Table] WHERE Id ='" + RManager_ID.Text + "' AND Name= '" + RManager_Name.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteScalar();
              

                    MessageBox.Show("Remove Manager Successfully");

              


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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }
    }
}
