using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Controller
    {
        Company Default = Company.GetInstance();
        Company UsedCompany;

        public void Control(Company InputCompany) {
            if (UsedCompany == null) 
            {
                UsedCompany = InputCompany;
            }
            else
            {
                Console.WriteLine("Currently using another company");
            }
        }

    }
}
