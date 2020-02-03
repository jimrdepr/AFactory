using System;
using System.Collections.Generic;
using System.Text;

namespace Abs_Factory
{
    class SamsungFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new GalaxyS2();
        }

        public IDumb GetDumb()
        {
            return new Primo();
        }
    }
}
