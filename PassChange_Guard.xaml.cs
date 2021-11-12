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
    /// Interaction logic for PassChange_Guard.xaml
    /// </summary>
    public partial class PassChange_Guard : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public PassChange_Guard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Park;Integrated Security=True");
            try
            {
                con.Open();




                if (GP_NewBox.Password == GP_ConBox.Password)
                {
                    string query = "UPDATE [Guard] SET  Password ='" + GP_NewBox.Password + "' WHERE Password = '" + GP_Box.Password + "' AND Email = '" + Email.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteScalar();



                    MessageBox.Show(" Save Password Successfully");




                }
                else
                {
                    MessageBox.Show("Password does not Match");
                }


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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EntryExit ee = new EntryExit();
            ee.Show();
            this.Hide();
        }
    }
}
