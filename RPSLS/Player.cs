using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player
    {
        
        public static string name = " ";
        public static string choice = " ";
        public static int score = 0;
        
        public static List<string> CurrentGesture()
        {
            List<string> chosen_gesture = new List<string>();
            chosen_gesture.Add("Rock");
            chosen_gesture.Add("Paper");
            chosen_gesture.Add("Scissors");
            chosen_gesture.Add("Lizard");
            chosen_gesture.Add("Spock");
            return chosen_gesture;
        }
       
    }
}
