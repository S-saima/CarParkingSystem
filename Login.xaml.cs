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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        string userErr, passErr;
        public Login()
        {
            InitializeComponent();
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            UserView uv = new UserView();
            uv.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (uName.Text == "")
            {
                userErr = "User Name is Required";
                userError.Content = userErr;
            }
            else
            {
                userError.Content = "";
            }
            if (uPass.Password == "")
            {
                passErr = "Password is Required";
                passError.Content = passErr;
            }

            else
            {
                passError.Content = "";
            }



            if (uName.Text != "" && uPass.Password != "" )
            {
                 
                SqlConnection con = new SqlConnection( @" Data Source=ASUS;Initial Catalog=Park;Integrated Security=True");
                try
                {
                    con.Open();
                    if (Combo.SelectedItem.Equals(ADMIN))
                    {
                        string query = "SELECT COUNT(*) FROM [LoginPage] WHERE UserName='" + uName.Text + "' AND Password='" + uPass.Password + "' ";

                        SqlCommand sqlcmd = new SqlCommand(query, con);


                        int a = Convert.ToInt32(sqlcmd.ExecuteScalar());
                        if (a == 1)
                        {
                            //F MessageBox.Show("Valid ");


                            Admin m = new Admin();
                            m.Show();
                            this.Hide();
                        }


                        else
                        {
                            MessageBox.Show("InValid!! TRY AGAIN");
                        }

                    }

                   else if (Combo.SelectedItem.Equals(GUARD))
                    {
                        string query = "SELECT COUNT(*) FROM [Guard] WHERE Name='" + uName.Text + "' AND Password='" + uPass.Password + "' ";

                        SqlCommand sqlcmd = new SqlCommand(query, con);


                        int a = Convert.ToInt32(sqlcmd.ExecuteScalar());
                        if (a == 1)
                        {
                            //F MessageBox.Show("Valid ");


                            EntryExit ee = new EntryExit();
                            ee.Show();
                            this.Hide();
                        }


                        else
                        {
                            MessageBox.Show("InValid!! TRY AGAIN");
                        }

                    }

                    else if (Combo.SelectedItem.Equals(MANAGER))
                    {
                        string query = "SELECT COUNT(*) FROM [M_Table] WHERE Name='" + uName.Text + "' AND Password='" + uPass.Password + "' ";

                        SqlCommand sqlcmd = new SqlCommand(query, con);


                        int a = Convert.ToInt32(sqlcmd.ExecuteScalar());
                        if (a == 1)
                        {
                            //F MessageBox.Show("Valid ");


                            Manager m = new Manager();
                            m.Show();
                            this.Hide();
                        }


                        else
                        {
                            MessageBox.Show("InValid!! TRY AGAIN");
                        }

                    }

                    else {
                        MessageBox.Show("Invalid");

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
}
