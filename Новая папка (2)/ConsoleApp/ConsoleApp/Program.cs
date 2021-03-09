using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    class ConsoleSettings
    {
        public ConsoleColor BackgroundColor = ConsoleColor.Yellow;
        public ConsoleColor ForegroundColor = ConsoleColor.DarkCyan;


        private static ConsoleSettings instance;

        private ConsoleSettings() { }    //блок создания объекта этого типа

        //public static ConsoleSettings Instance => instance ?? (instance = new ConsoleSettings());

        public static ConsoleSettings GetInstance()
        {
            if (instance is null) instance = new ConsoleSettings();

            return instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var settings = ConsoleSettings.GetInstance();
            var settings2 = ConsoleSettings.GetInstance();

            Console.WriteLine(settings == settings2);

            Console.BackgroundColor = settings.BackgroundColor;
            Console.ForegroundColor = settings.ForegroundColor;
            
            Console.WriteLine("Hello");
            
            Console.ReadKey();
        }
    }
}
