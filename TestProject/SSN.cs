using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class SSN : ISSN
    {

        private string _ssn = "";
        public string SSN_
        {

            get { return "***-**-1234"; }
            set { _ssn = value; }
        }

        private int _age = 0;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0 && value < 129)
                    _age = value;
            }
        }

        


    }
}
