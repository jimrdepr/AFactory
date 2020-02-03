using System;
using System.Collections.Generic;
using System.Text;

namespace Abs_Factory
{
    interface IPhoneFactory
    {
        public ISmart GetSmart();

        public IDumb GetDumb();
    }
}
