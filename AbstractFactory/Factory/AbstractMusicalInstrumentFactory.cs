using AbstractFactory.IFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    abstract class AbstractMusicalInstrumentFactory : IMusicalInstrumentFactory
    {
        public abstract IMusicalInstrument CreateMusicalInstrument();
    }
}
