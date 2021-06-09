using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Computer
    {
        public static void computer_choice()
        {
            var extraRandom = new Random();
            int choiceCount = extraRandom.Next(Player.CurrentGesture().Count);
            string choice = Player.CurrentGesture()[choiceCount];
            Console.WriteLine(choice);
        }
    }
}
