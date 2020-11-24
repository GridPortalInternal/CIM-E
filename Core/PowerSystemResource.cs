using System;
using System.Collections.Generic;
using System.Text;

namespace CIME.Core
{
    public abstract class PowerSystemResource : IdentifiedObject
    {
        public int region_id { get; set; }
    }
}
