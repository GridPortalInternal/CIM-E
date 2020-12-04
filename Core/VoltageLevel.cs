using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIME.Core
{
//    [Table("VoltageLevel")]
    public class VoltageLevel : EquipmentContainer
    {
        public double highkV { get; set; }

        public double lowkV { get; set; }

        public Substation Substation { get; set; }

        public BaseVoltage BaseVoltage { get; set; }

        public string Type { get; set; }
    }
}
