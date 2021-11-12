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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public Admin()
        {
            InitializeComponent();
        }

        private void G_Details_Click(object sender, RoutedEventArgs e)
        {
            Guard_Details1 gd = new Guard_Details1();
            gd.Show();
            this.Hide();
        }

        private void P_Details_Click(object sender, RoutedEventArgs e)
        {
            Parking_Details1 pd = new Parking_Details1();
            pd.Show();
            this.Hide();
        }

        private void A_Manager_Click(object sender, RoutedEventArgs e)
        {
            Add_Manager am = new Add_Manager();
            am.Show();
            this.Hide();
        }

        private void M_Details_Click(object sender, RoutedEventArgs e)
        {
            M_Details md = new M_Details();
            md.Show();
            this.Hide();
        }

        private void Log_Out_Click(object sender, RoutedEventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }

        private void R_Manager_Click(object sender, RoutedEventArgs e)
        {
            Remove_Manager rm = new Remove_Manager();
            rm.Show();
            this.Hide();
        }
    }
}
