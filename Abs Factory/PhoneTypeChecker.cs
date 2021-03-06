﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abs_Factory
{
    class PhoneTypeChecker
    {
        public IPhoneFactory factory;
        public Manufacturers manu;

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
            Console.WriteLine(manu);
            Console.WriteLine("Smart Phone: " + factory.GetSmart().GetName());
            Console.WriteLine("Dumb Phone: " + factory.GetDumb().GetName());
        }
        public enum Manufacturers
        {
            SAMSUNG,
            HTC,
            NOKIA
        }
    }
}
