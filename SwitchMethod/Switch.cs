using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchMethod
{
    internal class Switch
    {

        public void ChangeConsoleToGreenAndBlack()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

        }
        public void ChangeConsoleToYellowAndBlue()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

        }
        public void ChangeConsoleToMagentaAndRed()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

        }
        public void ChangeConsoleToDefault()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

        }

        public void SwitchConsoleColor()
        { 

            while(true){
            Console.WriteLine("Type '1' to switch to Green and Black Console\n'2' Yellow and Blue\n'3'Orange and Red\n'default' back to white and black");
            var ConsoleChoice = Console.ReadLine();
            switch(ConsoleChoice)
                
            {
                 
                case "1":
                    this.ChangeConsoleToGreenAndBlack();
                    break;

                    case "2":
                    this.ChangeConsoleToYellowAndBlue();
                    break;
                case "3":
                    ChangeConsoleToMagentaAndRed();
                        break;
                case "default":
                    this.ChangeConsoleToDefault();
                    break;

            } }
        }
    }
}
