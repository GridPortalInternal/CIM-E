using System;
using System.Collections.Generic;
using System.Text;

namespace CIME.Core
{
    public abstract class PowerSystemResourceWithPathname : PowerSystemResource
    {
        public string pathName { get; set; }
    }
}
