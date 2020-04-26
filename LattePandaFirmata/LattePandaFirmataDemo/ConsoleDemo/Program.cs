using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiFirmata;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args) {
            Arduino arduino = new Arduino();
            //
            arduino.pinMode(5, Arduino.INPUT);
            //
            arduino.didStringReceive += Arduino_didStringReceive;
            arduino.digitalPinUpdated += Arduino_digitalPinUpdated;
        }

        private static void Arduino_digitalPinUpdated(byte pin, byte state)
        {
            Console.WriteLine(String.Format("pin: {0}   state: {1}", pin, state));
            if (state == Arduino.HIGH && pin == 4)
            {
                Console.WriteLine("button is high");
            }
        }

        private static void Arduino_didStringReceive(ZiFirmata.Container.StringResult stringResult) {
            Console.WriteLine(String.Format("Key: {0}   Value01: {1}   Value02:{2}", stringResult.Key, stringResult.Value01, stringResult.Value02));
        }


    }
}
