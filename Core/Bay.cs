using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIME.Core
{
//    [Table("Bay")]
    public class Bay : EquipmentContainer
    {
        public Substation Substation { get; set; }

        public VoltageLevel VoltageLevel { get; set; }

        public BaseVoltage BaseVoltage { get; set; }

        public string Type { get; set; }
    }
}
