using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CIME.Core;

namespace CIME.Wires
{
    [Table("PowerTransformer")]
    public class PowerTransformer: Core.ConductingEquipment
    {
        public string type { get; set; }

        public Substation Substation { get; set; }

        public double NoLoadLoss { get; set; }

        public double ExcitingCurrent { get; set; }

        public Bay Bay { get; set; }
    }
}
