using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoogleProject
{
    class Messages
    {

        //declare variables
        private string name;
        private string email;
        private string inputMessage;


        //data validation for all fields
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
                    name = value;
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
                    email = value;
                }
            }
        }

        public string InputMessage
        {
            get
            {
                return inputMessage;
            }
            set
            {
                if (inputMessage == null)
                {
                    throw new Exception("Please enter a message");
                }
                else
                {
                    inputMessage = value;
                }
            }
        }

        //initialise class variables
        public Messages(string name, string email, string message)
        {
            this.name = name;
            this.email = email;
            inputMessage = message;
        }

        //visual representations of each variable
        public string NameText()
        {
            return name;
        }

        public string EmailText()
        {
            return email;
        }

        public string InputMessageText()
        {
            return inputMessage;
        }
    }
}
