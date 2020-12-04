using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIME.Wires
{
    /// <summary>
    /// Replace Enum TapChangerKind in CIM
    /// </summary>
//    [Table("TapChangerType")]
    public class TapChangerType : Core.IdentifiedObject
    {
        public int neutralStep { get; set; }

        public double neutralKV { get; set; }

        public int highStep { get; set; }

        public int lowStep { get; set; }

        public double stepVolIncre { get; set; }

        public int D { get; set; }
    }
}
