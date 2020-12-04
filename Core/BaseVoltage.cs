using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CIME.GEIRINA;

namespace CIME.Core
{
//    [Table("BaseVoltage")]
    public class BaseVoltage : IdentifiedObject
    {
        public double nomkV { get; set; }
    }
}
