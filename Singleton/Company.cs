using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Company
    {
        static Company MertDlkrn;
        string CompanyName;
        string CompanyShortName;
        string CompanyNo;

        private Company() {
            this.CompanyName = "MertDalkrn";
            this.CompanyShortName = "mrtdalkrn";
            this.CompanyNo = "0001";
        }

        public string GetCompanyName() {
            if (CompanyName == null) {
                return null;
            }
            return CompanyName;
        }

        public void SetCompanyName(Company InputCompany , string CompanyName)
        {
            this.CompanyName = CompanyName;
        }
        public string GetCompanyShortName()
        {
            if (CompanyShortName == null)
            {
                return null;
            }
            return CompanyShortName;
        }
        public void SetCompanyShortName(Company InputCompany, string CompanyShortName)
        {
            this.CompanyShortName = CompanyShortName;
        }
        public string GetCompanyNo()
        {
            if (CompanyName == null)
            {
                return null;
            }
            return CompanyNo;
        }
        public void SetCompanyNo(Company InputCompany, string CompanyNo)
        {
            if (CompanyNo == "0001")
            {
                Console.WriteLine("This CompanyNo not available");
            }
            else 
            { 
            InputCompany.CompanyNo = CompanyNo;
            }
        }
        public static Company GetInstance()
        {
            if (MertDlkrn == null) {
                MertDlkrn = new Company();
            }
            return MertDlkrn;
        }
        public string ToString(Company InputCompany) { 
            return ("Company Name = " + InputCompany.GetCompanyName() +" Company ShortName = "+ InputCompany.GetCompanyShortName() 
                + " Company No = " + InputCompany.GetCompanyNo() );
        }

    }
}
