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
    /// Interaction logic for ChangePass_M.xaml
    /// </summary>
    public partial class ChangePass_M : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public ChangePass_M()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Park;Integrated Security=True");
            try
            {
                con.Open();
            
                if (MP_NewBox.Password == MP_ConBox.Password)
                {
                    string query = "UPDATE [M_Table] SET  Password ='" + MP_NewBox.Password + "' WHERE Password = '" + MP_Box.Password + "' AND Email = '" + Email.Text + "' ";
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
            Manager m = new Manager();
            m.Show();
            this.Hide();
        }
    }
}
