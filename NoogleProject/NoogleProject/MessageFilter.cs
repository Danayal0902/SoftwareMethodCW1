using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoogleProject
{
    public class MessageFilter
    {
        private string name;
        private string email;
        private string message;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name == null)
                {
                    throw new Exception("Please enter a Name");
                }
                else
                {
                    value = name;
                }
            }
        }


        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email == null)
                {
                    throw new Exception("Please enter an email address");
                }
                else
                {
                    value = email;
                }
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                if (message == null)
                {
                    throw new Exception("Please enter a message");
                }
                else
                {
                    value = message;
                }
            }
        }

        public void Reader(string message)
        {
            try
            {
                using (StreamReader sr = new StreamReader("textwords.csv"))
                {
                    string row;

                    while ((row = sr.ReadLine()) != null)
                    {
                        if (message.Contains(row))
                        {
                            Console.WriteLine("Unacceptable word found");
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);

                Console.ReadLine();
            }
        }
    }
}
