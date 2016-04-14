using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoogleProject
{
    class KeywordFilter
    {
        public List<string> institutionList = new List<string>();

        public List<string> subjectList = new List<string>();

        public String LevelSelect(string message)
        {
            message = message.ToUpper();

            if ((message.Contains("UG")) || (message.Contains("U/G")) || (message.Contains("UNDERGRAD")) || (message.Contains("UNDERGRADUATE")))
            {
                return "Undergraduate";
            }
            else if ((message.Contains("PG")) || (message.Contains("P/G")) || (message.Contains("POSTGRAD")) || (message.Contains("POSTGRADUATE")))
            {
                return "Postgraduate";
            }
            else
            {
                return "Undergraduate & Postgraduate";
            }
        }


        public List<string> institutionFilter(string message)
        {
            using (StreamReader sr = new StreamReader("UniversityList.csv"))
            {
                string row;


                while ((row = sr.ReadLine()) != null)
                {
                    if (message.Contains(row))
                    {
                        Console.WriteLine(row);
                        institutionList.Add(row);
                    }
                }
                return institutionList;
            }
        }


        public List<string> subjectFilter(string message)
        {
            using (StreamReader sr = new StreamReader("subjects.csv"))
            {
                string row;

                while ((row = sr.ReadLine()) != null)
                {
                    if (message.Contains(row))
                    {
                        Console.WriteLine(row);
                        subjectList.Add(row);
                    }
                }
                return subjectList;
            }
        }
    }
}
