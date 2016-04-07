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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NoogleProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageFilter mf = new MessageFilter();

            Messages m = new Messages(txtName.Text, txtEmail.Text, txtMessage.Text);

            if (mf.Reader(m.InputMessage) == true)
            {
                MessageBox.Show("Unacceptable word(s) detected");
            }
            else
            {
                //send to valid file
            }
        }   
    }
}
