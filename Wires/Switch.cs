using CIME.Core;

namespace CIME.Wires
{
    public class Switch : Core.ConductingEquipment
    {
        public Substation Substation { get; set; }

        public BaseVoltage BaseVoltage { get; set; }

        public VoltageLevel VoltageLevel { get; set; }

        public int status { get; set; }

        public Bay Bay { get; set; }
    }
}
