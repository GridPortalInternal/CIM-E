using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CIME.Core;

namespace CIME.LoadModel
{
    [Table("Load")]
    public class Load : ConformLoad
    {
        public Substation Substation { get; set; }

        public string I_node { get; set; }

        public BaseVoltage BaseVoltage { get; set; }

        public VoltageLevel VoltageLevel { get; set; }

        public double P { get; set; }

        public double Q { get; set; }

        public Bay Bay { get; set; }

        public double inom { get; set; }
    }
}
