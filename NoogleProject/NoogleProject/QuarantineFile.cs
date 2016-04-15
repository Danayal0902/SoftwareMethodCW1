using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoogleProject
{
    class QuarantineFile
    {
        //singleton class
        private static QuarantineFile instance;

        private QuarantineFile() { }

        public static QuarantineFile getInstance()
        {
            if (instance == null)
            {
                instance = new QuarantineFile();
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
