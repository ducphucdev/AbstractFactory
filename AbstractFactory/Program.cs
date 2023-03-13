using AbstractFactory.Factory;
using AbstractFactory.IFactory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] arg)
        {
            IMusicalInstrumentFactory factory;

            Random random = new Random();
            int type = random.Next(0, 2);

            if (type == 0)
            {
                factory = new StringMIFactory();
            }
            else
            {
                factory = new KeyboardMIFactory();
            }

            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());
            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());
            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());
            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());
            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());

        }
    }
}