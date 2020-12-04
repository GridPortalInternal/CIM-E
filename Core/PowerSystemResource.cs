using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIME.Core
{
#if TPT
//    [Table("PowerSystemResource")]
#endif
    public class PowerSystemResource : IdentifiedObject
    {
        public int region_id { get; set; }
    }
}
