using System;
using System.Collections.Generic;
using System.Text;

namespace CIME.GEIRINA
{
    public interface IDatabaseIO
    {
        void CreateTable(IDatabaseConnection conn);

        void InsertInto(IDatabaseConnection conn);
    }
}
