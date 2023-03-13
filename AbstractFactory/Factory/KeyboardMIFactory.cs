using AbstractFactory.MusicalInstrument.Keyboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class KeyboardMIFactory : AbstractMusicalInstrumentFactory
    {
        public override IMusicalInstrument CreateMusicalInstrument()
        {
            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
            {
                //CHƯA MỞ RỘNG OBEJCT PIANO
                return new Piano();

            }
            else
            {
                return new PipeOrgan();
            }
        }
    }


    // ĐÃ MỞ RÔNG OBJECT PIANO

    //Random randomPiano = new Random();
    //int typePiano = randomPiano.Next(0, 2);
    //if (typePiano == 0)
    //{
    //    return new DigitalPiano();
    //}
    //else
    //{
    //    return new AcousticPiano();
    //}
}
