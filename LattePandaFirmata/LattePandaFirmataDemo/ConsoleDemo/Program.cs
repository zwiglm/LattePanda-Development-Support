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

            arduino.didStringReceive += Arduino_didStringReceive;
        }

        private static void Arduino_didStringReceive(ZiFirmata.Container.StringResult stringResult) {
            Console.WriteLine(String.Format("Key: {0}   Value: {1}", stringResult.Key, stringResult.Value));
        }
    }
}
