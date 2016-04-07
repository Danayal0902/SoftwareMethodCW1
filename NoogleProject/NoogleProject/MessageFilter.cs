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


        public bool Reader(string message)
        {
            try
            {
                //find csv file using streamreader
                using (StreamReader sr = new StreamReader("textwords.csv"))
                {
                    string row;

                    while ((row = sr.ReadLine()) != null)
                    {
                        row = Regex.Escape(row).Replace(",", "");

                        if (message.Contains(row))
                        {
                            Console.WriteLine("Unacceptable word(s) found, message sent to quarantine file");
                            return true;
                        }
                    }
                        
                            Console.WriteLine("Message sent to valid file");
                            return false;
                        }
                    }      
                
            
            catch (Exception)
            {
                throw new Exception("File not found");
                
            }
        }
    }
}
