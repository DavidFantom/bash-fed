using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chel
{

    class Chelovek
    {
        public virtual string Name { get; set; }
        public virtual void Zdorov()
        {
            Console.WriteLine("Человек здоров");
        }
    }

    class NerveSysDecorator : Chelovek
    {
        protected Chelovek _source;

        public NerveSysDecorator(Chelovek source)
        {
            _source = source;
        }

        public override string Name
        {
            get { return _source.Name; }
            set { _source.Name = value; }
        }
        public override void Zdorov() { _source.Zdorov(); }
    }

    class BrainsDecorator : NerveSysDecorator
    {
        public BrainsDecorator(Chelovek source) : base(source) { }

        public override void Zdorov()
        {
            _source.Zdorov();
            Console.WriteLine("Мозги в порядке");
        }
    }

    class NerveDecorator : NerveSysDecorator
    {
        public NerveDecorator(Chelovek source) : base(source) { }

        public override void Zdorov()
        {
            _source.Zdorov();
            Console.WriteLine("Нервы в порядке");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var сhelovek = new Chelovek();
            сhelovek = new BrainsDecorator(сhelovek);

            сhelovek.Zdorov();
            Console.WriteLine();
            Thread.Sleep(1000);

            сhelovek = new Chelovek();
            сhelovek = new NerveDecorator(сhelovek);

            сhelovek.Zdorov();
            Console.WriteLine();
            Thread.Sleep(1000);

            сhelovek = new Chelovek();
            сhelovek = new BrainsDecorator(сhelovek);
            сhelovek = new NerveDecorator(сhelovek);

            сhelovek.Zdorov();
            Thread.Sleep(1000);
            
            Console.ReadKey();
        }
    }
}
