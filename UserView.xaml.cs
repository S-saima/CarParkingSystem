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
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : Window
    {
        public UserView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Park;Integrated Security=True");

            try {
                con.Open();


                string query = " select count(*) from [AllDetails] Where Vehicle_Exit_Time IS NULL AND Vehicle_Type='" + V_Type.Text+"' AND Branch='"+Branch_Name.Text+"' ";

                SqlCommand sqlcmd = new SqlCommand(query, con);

                
                Int32 rows_count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                rows_count = 15 - rows_count; //
                sqlcmd.Dispose();
                con.Close();

                label1.Text = "Total space 15 where there are " + rows_count+ " space for the vehicle";

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
            Login l = new Login();
            l.Show();
            this.Hide();

        }
    }
}
