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
    /// Interaction logic for Add_Guard.xaml
    /// </summary>
    public partial class Add_Guard : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public Add_Guard()
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
                if (G_Password.Password == G_Confirm.Password)
                {
                    
                     string query = "INSERT INTO [Guard] (Name, Email, Address, Password,Gender,Date_of_Birth,Branch) VALUES('" + G_Name.Text + "','" + G_Email.Text + "','" + G_Address.Text + "','" + G_Password.Password + "','" + G_Gender.Text + "','" + G_DOB.Text + "','" + Branch_Name.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteScalar();
                    MessageBox.Show("Add Guard Successfully");
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
