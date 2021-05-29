﻿using System;
using System.Collections.Generic;

namespace Insulter
{
  class Program
  {
    static int RandomNumber(int min, int max)
    {
      var rand = new Random();
      return rand.Next(min, max);
    }
    static void Main(string[] args)
    {
      List<string> insults = new List<string>
      {
        "You look like what morning breath smells like.",
        "If you tried to give me cpr I would probably throw myself back under water",
        "I am not a fan of you",
        "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
        "I'd rather walk than be on the same plane as you",
        "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
        "Do you have to be so...like that?"
      };


      List<int> indexes = new List<int>();

      while (indexes.Count < 3)
      {
        int spot = RandomNumber(0, insults.Count - 1);

        if (!indexes.Contains(spot))
        {
          indexes.Add(spot);
        }
      }

      for (int i = 0; i < indexes.Count; i++)
      {
        int index = indexes[i];
        Console.WriteLine(insults[index]);
      }

    }
  }
}
