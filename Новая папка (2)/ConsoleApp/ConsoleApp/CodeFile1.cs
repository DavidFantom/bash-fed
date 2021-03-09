using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Decorator
{

    class Track
    {
        public virtual string Name { get; set; }
        public virtual void Play()
        {
           // Console.WriteLine("");
        }
    }

    class BaseTrackDecorator : Track
    {
        protected Track _source;

        public BaseTrackDecorator(Track source)
        {
            _source = source;
        }

        public override string Name
        {
            get { return _source.Name; }
            set { _source.Name = value; }
        }
        public override void Play() {_source.Play();}
    }

    class DrumDecorator : BaseTrackDecorator
    {
        public DrumDecorator(Track source) : base(source){}

        public override void Play()
        {
            _source.Play();
            Console.Write(" 'Типо играют барабаны' ");
        }
    }

    class VoiceDecorator : BaseTrackDecorator
    {
        public VoiceDecorator(Track source) : base(source){}

        public void Play()
        {
            _source.Play();
            Console.Write(" 'Типо вокал' ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var track = new Track();
            track = new DrumDecorator(track);

            var count = 10;
            while (count>10)
            {
                Thread.Sleep(1000);
                count--;
                track.Play();
            }
            Console.WriteLine();
            Console.WriteLine();

            track = new Track();
            track = new VoiceDecorator(track);

            count = 10;
            while (count>10)
            {
                Thread.Sleep(1000);
                count--;
                track.Play();
            }
            Console.WriteLine();
            Console.WriteLine();

            track = new Track();
            track = new VoiceDecorator(track);
            track = new DrumDecorator(track);

            count = 10;
            while (count>10)
            {
                Thread.Sleep(1000);
                count--;
                track.Play();
            }
            Console.ReadKey();
        }
    }
}
