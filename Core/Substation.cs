using System;
using System.Collections.Generic;
using System.Text;
using CIME.GEIRINA;

namespace CIME.Core
{
    public class Substation : EquipmentContainer, IDatabaseIO
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

        public void CreateTable(IDatabaseConnection conn)
        {
            throw new NotImplementedException();
        }

        public void InsertInto(IDatabaseConnection conn)
        {
            throw new NotImplementedException();
        }
    }
}
