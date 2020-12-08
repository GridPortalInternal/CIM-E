using System.ComponentModel.DataAnnotations.Schema;

namespace CIME.Wires
{
#if TPT
    [Table("ProtectedSwitch")]
#endif
    public class ProtectedSwitch : Switch
    {
    }
}
