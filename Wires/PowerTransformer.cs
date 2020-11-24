using System;
using System.Collections.Generic;
using System.Text;
using CIME.Core;
using CIME.GEIRINA;

namespace CIME.Wires
{
   public class PowerTransformer: Core.ConductingEquipment, IDatabaseIO
    {
        public string type { get; set; }

        public Substation Substation { get; set; }

        public double NoLoadLoss { get; set; }

        public double ExcitingCurrent { get; set; }

        public Bay Bay { get; set; }

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
