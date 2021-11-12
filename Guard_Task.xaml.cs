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
    /// Interaction logic for Guard_Task.xaml
    /// </summary>
    public partial class Guard_Task : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public Guard_Task()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Park;Integrated Security=True");
            try
            {
                con.Open();
              

                    string query = "INSERT INTO [AllDetails] (USer_Name,User_Phone,User_Address,Token_Id, Vehicle_No, Vehicle_Type, Branch, Vehicle_Entry_Time) VALUES('" + User_Name.Text + "','" + User_Phone.Text + "','" + User_Address.Text + "','" + U_Id.Text + "','" + V_No.Text + "','" + V_Type.Text + "','" +Branch_Name.Text + "','" + Entry_Time.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                   cmd.ExecuteScalar();

                   MessageBox.Show("Data Saved Successfully");

                
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

