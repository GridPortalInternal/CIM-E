using System.ComponentModel.DataAnnotations.Schema;

namespace CIME.Wires
{
    [Table("Disconnector")]
    public class Disconnector : Switch
    {
        public string I_node { get; set; }

        public string J_node { get; set; }
    }
}
