using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIME.ControlArea
{
    [Table("ControlArea")]
    public class ControlArea : Core.PowerSystemResource
    {
        public string Parent { get; set; }

        public double P { get; set; }

        public double Q { get; set; }
    }
}
