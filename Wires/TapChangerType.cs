using System;
using System.Collections.Generic;
using System.Text;
using CIME.GEIRINA;

namespace CIME.Wires
{
    /// <summary>
    /// Replace Enum TapChangerKind in CIM
    /// </summary>
    public class TapChangerType : Core.IdentifiedObject, IDatabaseIO
    {
        public int neutralStep { get; set; }

        public double neutralKV { get; set; }

        public int highStep { get; set; }

        public int lowStep { get; set; }

        public double stepVolIncre { get; set; }

        public int D { get; set; }

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
