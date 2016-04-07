using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoogleProject
{
    class QuarantineFile
    {
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
    }
}
