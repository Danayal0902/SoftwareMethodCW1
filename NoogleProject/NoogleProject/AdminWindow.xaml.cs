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
        QuarantineFile quarantine = QuarantineFile.getInstance();
        public AdminWindow()
        {
            InitializeComponent();
            rdoQuarantine.IsChecked = true;
            txtblkMessages.Text = quarantine.QuarantineList.ToString();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Owner.Show();
        }
    }
}
