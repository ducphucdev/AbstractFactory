using AbstractFactory.MusicalInstrument.Keyboard;
using AbstractFactory.MusicalInstrument.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class RandomMIFactory : AbstractMusicalInstrumentFactory
    {
        //CHƯA MỞ RỘNG OBJECT PIANO

        public override IMusicalInstrument CreateMusicalInstrument()
        {
            Random random = new Random();
            int type = random.Next(0, 4);
            if (type == 0)
            {
                return new Piano();
            }
            else if (type == 1)
            {
                return new PipeOrgan();
            }

            else if (type == 2)
            {
                return new Guitar();
            }
            else
            {
                return new Violin();
            }
        }

        // ĐÃ MỞ RỘNG OBJECT PIANO
        //public override IMusicalInstrument CreateMusicalInstrument()
        //{
        //    Random random = new Random();
        //    int type = random.Next(0, 5);
        //    if (type == 0)
        //    {
        //        Random randomPiano = new Random();
        //        int typePiano = randomPiano.Next(0, 2);
        //        if(typePiano == 0)
        //        {
        //            return new DigitalPiano();
        //        }
        //        else
        //        {
        //            return new AcousticPiano();
        //        }
        //    }
        //    else if (type == 1)
        //    {
        //        return new PipeOrgan();
        //    }

        //    else if (type == 2)
        //    {
        //        return new Guitar();
        //    }
        //    else
        //    {
        //        return new Violin();
        //    }
        //}
    }
}
