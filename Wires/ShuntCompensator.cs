using System.ComponentModel.DataAnnotations.Schema;
using CIME.Core;

namespace CIME.Wires
{
    [Table("ShuntCompensator")]
    public class ShuntCompensator : RegulatingCondEq
    {
        public double nomQ { get; set; }

        public double V_rate { get; set; }

        public string I_node { get; set; }

        public BaseVoltage BaseVoltage { get; set; }

        public VoltageLevel VoltageLevel { get; set; }

        public Substation Substation { get; set; }

        public double Q { get; set; }

        public Bay Bay { get; set; }

        public string Cp_type { get; set; }
    }
}
