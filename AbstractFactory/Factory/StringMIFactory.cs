using AbstractFactory.MusicalInstrument.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class StringMIFactory : AbstractMusicalInstrumentFactory
    {
        public override IMusicalInstrument CreateMusicalInstrument()
        {
            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
            {
                return new Guitar();
            }
            else
            {
                return new Violin();
            }    
        }
    }
}
