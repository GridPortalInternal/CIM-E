using CIME.Core;
using CIME.GEIRINA;

namespace CIME.Wires
{
    public class SeriesCompensator: Core.ConductingEquipment, IDatabaseIO
    {
        public double r { get; set; }

        public double x { get; set; }

        public string I_node { get; set; }

        public string J_node { get; set; }

        public BaseVoltage BaseVoltage { get; set; }

        public VoltageLevel VoltageLevel { get; set; }

        public Substation Substation { get; set; }

        public double Pi { get; set; }

        public double Qi { get; set; }

        public double Pj { get; set; }

        public double Qj { get; set; }

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
