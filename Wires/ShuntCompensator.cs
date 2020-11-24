using CIME.Core;
using CIME.GEIRINA;

namespace CIME.Wires
{
    public class ShuntCompensator : RegulatingCondEq, IDatabaseIO
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

        public void CreateTable(IDatabaseConnection conn)
        {
            throw new System.NotImplementedException();
        }

        public void InsertInto(IDatabaseConnection conn)
        {
            throw new System.NotImplementedException();
        }
    }
}
