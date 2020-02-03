using System;

namespace Abs_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneTypeChecker phone;

            foreach(PhoneTypeChecker.Manufacturers m in Enum.GetValues(typeof(PhoneTypeChecker.Manufacturers)))
            {
                phone = new PhoneTypeChecker(m);
                phone.CheckProducts();
            }
        }
    }
}
