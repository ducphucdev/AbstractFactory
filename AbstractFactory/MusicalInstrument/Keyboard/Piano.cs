using AbstractFactory.AbstractMusicalInstrument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MusicalInstrument.Keyboard
{
    //CHƯA MỞ RÔNG OBJECT PIANO
    class Piano : KeyboardMusicalInstrument
    {
        public override string GetNameMusicalInstrument()
        {
            return "I'm a PIANO";
        }
    }
}
