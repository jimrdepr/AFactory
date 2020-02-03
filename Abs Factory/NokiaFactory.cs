using System;
using System.Collections.Generic;
using System.Text;

namespace Abs_Factory
{
    class NokiaFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new Titan();
        }

        public IDumb GetDumb()
        {
            return new Asha();
        }
    }
}
