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
        //delcare lists containing information from the message entered by user

        public List<string> institutionList = new List<string>();

        public List<string> subjectList = new List<string>();


        //method to see what level of course the user is searching for
        public string LevelSelect(string message)
        {
            //up case the entered message
            message = message.ToUpper();

            //if statement to containing differerent abbreviations the user may enter
            if ((message.Contains("UG")) || (message.Contains("U/G")) || (message.Contains("UNDERGRAD")) || (message.Contains("UNDERGRADUATE")))
            {
                //return search criteria to console
                Console.WriteLine("Level: Undergraduate");
                return "Undergraduate";
            }
            else if ((message.Contains("PG")) || (message.Contains("P/G")) || (message.Contains("POSTGRAD")) || (message.Contains("POSTGRADUATE")))
            {
                Console.WriteLine("Level: Postgraduate");
                return "Postgraduate";
            } 
            else
            {
                Console.WriteLine("Level: Both Undergraduate & Postgraduate");
                return "Undergraduate & Postgraduate";
            }
        }

        //list filter for unis entered in the message
        public List<string> institutionFilter(string message)
        {
            //compare unis entered to csv file
            using (StreamReader sr = new StreamReader("UniversityList.csv"))
            {
                string row;

                //up case message entered
                message = message.ToUpper();

                while ((row = sr.ReadLine()) != null)
                {
                    //upcase csv file rows to match message being up cased
                    var upper = row.ToUpper();
                    if (message.Contains(upper))
                    {
                        Console.WriteLine(row);
                        institutionList.Add(row);
                    }
                }
                //return uni list
                return institutionList;
            }
        }

        //list filter for subjects entered in message
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

        //public string showMessage()
        //{
        //    var message = "";

        //    message = ("You've chosen: " + returnSubject() + ", at the following uni(s): " + returnInstitution());

        //    return message;
        //}

        //public string returnSubject()
        //{
        //    var returnValue = string.Join(", ", subjectList.ToArray());
        //    return returnValue;
        //}

        //public string returnInstitution()
        //{
        //    var returnValue = string.Join(", ", institutionList.ToArray());
        //    return returnValue;
        //}
    }
}
