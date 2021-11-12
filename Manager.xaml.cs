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

namespace demo
{
    /// <summary>
    /// Interaction logic for Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public Manager()
        {
            InitializeComponent();
        }

        private void A_Guard_Click(object sender, RoutedEventArgs e)
        {
            Add_Guard ag = new Add_Guard();
            ag.Show();
            this.Hide();
        }

        private void R_Guard_Click(object sender, RoutedEventArgs e)
        {
            Remove_Guard rg = new Remove_Guard();
            rg.Show();
            this.Hide();
        }

        private void G_Details_Click(object sender, RoutedEventArgs e)
        {
            Guard_Details gd = new Guard_Details();
            gd.Show();
            this.Hide();
        }

        private void P_Details_Click(object sender, RoutedEventArgs e)
        {
            Parking_Details pd = new Parking_Details();
            pd.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ChangePass_M changepm = new ChangePass_M();
            changepm.Show();
            this.Hide();

        }
    }
}
