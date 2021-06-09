using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human
    {
        public static string choice()
        {
            Console.WriteLine("The choices are: ");
            foreach (string index in Player.CurrentGesture())
            {
               Console.WriteLine(index);
            }
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("What is your choice of gesture?");
                string player_gesture = Console.ReadLine();
                foreach (string item in Player.CurrentGesture()) { 
                    if (item == player_gesture)
                    {
                        return player_gesture;
                    }
                }
            }
        }        
    }
}
