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

namespace NoogleProject
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        //get the instance from the quarantine file
        QuarantineFile quarantine = QuarantineFile.getInstance();
        ValidFile valid = ValidFile.getInstance();
        public AdminWindow()
        {
            InitializeComponent();

            //make the source for the box the list of quarantined messages
            cboQuarantine.ItemsSource = quarantine.MessageList;
            cboQuarantine.DisplayMemberPath = "InputMessage";

            //make the source for the box the list of valid messages
            cboValid.ItemsSource = valid.MessageList;
            cboValid.DisplayMemberPath = "InputMessage";
        }

        //method to close the current window and return to main window
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Owner.Show();
        }
    }
}
