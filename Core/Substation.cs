using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIME.Core
{
//    [Table("Substation")]
    public class Substation : EquipmentContainer
    {
        public double Bv_id { get; set; }

        public string Type { get; set; }

        public ControlArea.ControlArea ControlArea { get; set; }

        public double  P { get; set; }

        public double Q { get; set; }

        public double x { get; set; }

        public double y { get; set; }

        public int i_flag { get; set; }

        public int mGdis_flag { get; set; }

        public int mUnXf_flag { get; set; }

        public BaseVoltage BaseVoltage { get; set; }
    }
}
