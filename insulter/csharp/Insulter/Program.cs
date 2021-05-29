using System;
using System.Collections.Generic;

/* const insults = [
    "You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"
  ];

  // This code ensures we don't end up with duplicate insults
  const indexes = [];
  while (indexes.length < 3) {
    const candidate = getRandomInt(0, insults.length - 1);
    if (!indexes.includes(candidate)) {
      indexes.push(candidate);
    }
  }

  for (let i=0; i<indexes.length; i++) {
    const index = indexes[i];
    console.log(insults[index]);
  }
}

// Remember getting a random integer in C# is different
function getRandomInt(min, max) {
  min = Math.ceil(min);
  max = Math.floor(max);
  return Math.floor(Math.random() * (max - min + 1)) + min;*/

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
