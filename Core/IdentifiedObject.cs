using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIME.Core
{
#if TPT
//    [Table("IdentifiedObject")]
#endif
    public class IdentifiedObject
    {
        [Key]
        public string mRID { get; set; }

        public string name { get; set; }
    }
}
