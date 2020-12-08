using System.ComponentModel.DataAnnotations.Schema;
using CIME.Core;

namespace CIME.Wires
{
    [Table("TransformerWinding")]
    public class TransformerWinding : Core.ConductingEquipment
    {
        public string WindingType { get; set; }

        public Substation Substation { get; set; }

        public PowerTransformer PowerTransformer { get; set; }

        public string I_node { get; set; }

        public string knd { get; set; }

        public BaseVoltage BaseVoltage { get; set; }

        public VoltageLevel VoltageLevel { get; set; }

        public TapChangerType TapChangerType { get; set; }

        public double ratedMVA { get; set; }

        public double ratedkV { get; set; }

        public double loadLoss { get; set; }

        public double leakageImpedence { get; set; }

        public double x { get; set; }

        public double r { get; set; }

        public double x0 { get; set; }

        public double r0 { get; set; }

        public double P { get; set; }

        public double Q { get; set; }

        public double D { get; set; }

        public Bay Bay { get; set; }
    }
}
