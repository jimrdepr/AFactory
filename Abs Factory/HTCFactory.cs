using System;
using System.Collections.Generic;
using System.Text;

namespace Abs_Factory
{
    class HTCFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new Lumia();
        }

        public IDumb GetDumb()
        {
            return new Genie();

        }
    }
}
