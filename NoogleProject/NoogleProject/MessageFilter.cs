using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NoogleProject
{
    public class MessageFilter
    {
        private string text;

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if(value != null)
                {
                    text = value;
                }
                else
                {
                    throw new Exception("You must enter a message");
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
                        row = Regex.Escape(row).Replace(",", "");

                        if (message.Contains(row))
                        {
                            Console.WriteLine("Unacceptable word found, message will be sent to quarantine");
                        }
                        else
                        {
                            Console.WriteLine("Message valid");
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
