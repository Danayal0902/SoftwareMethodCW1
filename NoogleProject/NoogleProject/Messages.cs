using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoogleProject
{
    class Messages
    {
        private string name;
        private string email;
        private string inputMessage;

        public Messages(string name, string email, string message)
        {
            this.name = name;
            this.email = email;
            this.inputMessage = message;
        }


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

<<<<<<< HEAD
        public Messages(string name, string email, string message)
        {
            this.name = name;
            this.email = email;
            inputMessage = message;
        }
=======
        
>>>>>>> 7602808a56bbed60a9a36edf912a71e32c346f2b

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
