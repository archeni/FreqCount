﻿using System;
using System.Collections.Generic;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> items = new List<string>
      {
        "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
        "The ability to think of interesting wishes on short notice",
        "A washtub of Skittles",
        "World peace, but not the kind of world peace where all the humans are removed from existence",
        "A TV that is NOT internet-capable",
        "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
      };

      foreach (var item in items)
      {
        Console.WriteLine(item);
      }
    }
  }
}
