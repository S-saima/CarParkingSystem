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
    /// Interaction logic for Add_Manager.xaml
    /// </summary>
    public partial class Add_Manager : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public Add_Manager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Park;Integrated Security=True");
            try
            {
                con.Open();
                if (M_Password.Password == M_Confirm.Password)
                {

                    string query = "INSERT INTO [M_Table] (Name, Email, Address, Password,Gender,Date_of_Birth,Branch) VALUES('" + M_Name.Text + "','" + M_Email.Text + "','" + M_Address.Text + "','" + M_Password.Password + "','" + M_Gender.Text + "','" + M_DOB.Text + "','" + Branch_Name.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteScalar();
                    
                    
                     MessageBox.Show("Add Manager Successfully");

                }
                else
                {

                    MessageBox.Show("Passoword does not Match ");

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
    }
}
