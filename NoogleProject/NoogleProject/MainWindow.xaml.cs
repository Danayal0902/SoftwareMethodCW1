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
            //try catch to require information from all text boxes
            try
            {

                MessageFilter mf = new MessageFilter();

                Messages m = new Messages(txtName.Text, txtEmail.Text, txtMessage.Text);

                if (mf.Reader(m.InputMessage) == true)
                {
                    //send to quarantine file

                    MessageBox.Show("Unacceptable word(s) detected");
                    QuarantineFile quarantine = QuarantineFile.getInstance();
                    quarantine.MessageList.Add(m);

                    //clear the message box
                    txtMessage.Clear();
                    
                }
                else
                {
                    //send to valid file
                    MessageBox.Show("Message sent");

                    ValidFile valid = ValidFile.getInstance();
                    valid.MessageList.Add(m);

                    //take all areas of valid message from message box and process
                    KeywordFilter keywords = new KeywordFilter();
                    var qualification = keywords.LevelSelect(m.InputMessage);
                    var subject = keywords.subjectFilter(m.InputMessage);
                    var uni = keywords.institutionFilter(m.InputMessage);
                    var name = m.Name;
                    var email = m.Email;

                    
                    MessageBox.Show("You have chosen: " + qualification);
                    
                    txtMessage.Clear();
                    txtName.Clear();
                    txtEmail.Clear();               
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill all required fields");
            }
        }
        

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            //hide the current window and open admin window
            AdminWindow admin = new AdminWindow();
            admin.Owner = this;
            admin.Show();
            Hide();    
        }

        
    }
}
