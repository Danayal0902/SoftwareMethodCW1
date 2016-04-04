using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoogleProject
{
    public class Messages
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
    }
}
