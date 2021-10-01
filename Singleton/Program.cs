using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Company CompanyDemo1 = Company.GetInstance();
            Console.WriteLine(CompanyDemo1);
            Console.WriteLine(CompanyDemo1.GetCompanyName());
            Console.WriteLine(CompanyDemo1.GetCompanyShortName());
            Console.WriteLine(CompanyDemo1.GetCompanyNo());

        }
    }
}
