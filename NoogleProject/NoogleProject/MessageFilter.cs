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
