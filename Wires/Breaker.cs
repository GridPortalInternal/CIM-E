using System.ComponentModel.DataAnnotations.Schema;
using CIME.Core;

namespace CIME.Wires
{
    [Table("Breaker")]
    public class Breaker : ProtectedSwitch
    {
        public string type { get; set; }

        public string I_node { get; set; }

        public string J_node { get; set; }

        public double mvarating { get; set; }
    }
}
