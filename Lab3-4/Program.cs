﻿using System;
using System.Text.RegularExpressions;
namespace Lab3_4
{


    class Program
    {
        static void Main(string[] args)
        {
            //This is 2a
            string pattern2a = @"[d-e]";
        string input2a = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input2a, pattern2a, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
        //Thisbis 2a
        string pattern2b = @"[d-e][*d]";
        string input2b = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions options2a = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input2b, pattern2b, options2a))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
        //This is 2c
        string pattern2c = @"[a][a-z][a]";
        string input2c = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions options2c = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input2c, pattern2c, options2c))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
        //This is 2d
        string pattern2d = @"[ ][p][a-z]*";
        string input2d = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions options2d = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input2d, pattern2d, options2d))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
        //This is 2e
        string pattern2e = @"[a-z]*[e][ ]";
        string input2e = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions options2e = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input2e, pattern2e, options2e))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
        //This is 2f
        string pattern2f = @"[A-Z]";
        string input2f = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions options2f = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input2f, pattern2f, options2f))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}
}