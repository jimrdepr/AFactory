using System;
using System.Collections.Generic;
using System.Text;

namespace Abs_Factory
{
    class PhoneTypeChecker
    {
        IPhoneFactory factory;
        Manufacturers manu;

        public PhoneTypeChecker(Manufacturers m)
        {
            manu = m;

            if (manu == Manufacturers.SAMSUNG)
                factory = new SamsungFactory();

            if (manu == Manufacturers.HTC)
                factory = new HTCFactory();

            if (manu == Manufacturers.NOKIA)
                factory = new NokiaFactory();
        }

        public void CheckProducts()
        {
            string smart = factory.GetSmart();

            Console.WriteLine("Smart Phone: " + factory.GetSmart());
            Console.WriteLine("Dumb Phone: " + factory.GetDumb());
        }
        public enum Manufacturers
        {
            SAMSUNG,
            HTC,
            NOKIA
        }
    }
}
