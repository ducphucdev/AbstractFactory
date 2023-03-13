using AbstractFactory.IFactory;
using AbstractFactory.MusicalInstrument.Keyboard;
using AbstractFactory.MusicalInstrument.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class BasicMIFactory : IMusicalInstrumentFactory
    {

        int index = 0;
        public IMusicalInstrument CreateMusicalInstrument()
        {
            if (index == 0)
            {
                index++;
                return new Piano();


                // ĐÃ MỞ RỘNG OBJECT PIANO
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

            if (index == 1)
            {
                index++;
                return new PipeOrgan();
            }

            if (index == 2)
            {
                index++;
                return new Guitar();
            }

            if (index == 3)
            {
                index = 0;
                return new Violin();
            }

            return null;
        }
    }
}
