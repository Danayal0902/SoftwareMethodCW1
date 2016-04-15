using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoogleProject
{
    class ValidFile
    {
        //singleton class
        private static ValidFile instance;

        private ValidFile() { }
        
        public static ValidFile getInstance()
        {
            if (instance == null)
            {
                instance = new ValidFile();
            }
            return instance;
        }

        //declare list for this class
        private List<Messages> messageList = new List<Messages>();

        //public properties for the declared list
        public List<Messages> MessageList
        {
            get
            {
                return messageList;
            }
            set
            {
                messageList = value;
            }
        }
    }
}
