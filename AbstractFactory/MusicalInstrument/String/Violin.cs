using AbstractFactory.AbstractMusicalInstrument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MusicalInstrument.String
{
    class Violin : StringMusicalInstrument
    {
        public override string GetNameMusicalInstrument()
        {
            return "I'm a VIOLIN";
        }
    }
}
