using System;
using System.Collections.Generic;

namespace DinnerParty
{
  class Program
  {
    static List<Guest> getGuests()
    {
      List<Guest> guests = new List<Guest>
      {
        new Guest
        {
          name = "Marilyn Monroe",
          occupation = "entertainer",
          bio = "(1926 - 1962) American actress, singer, model"
        },
        new Guest
        {
          name = "Abraham Lincoln",
          occupation = "politician",
          bio = "(1809 - 1865) US President during American civil war"
        },
        new Guest
        {
          name = "Martin Luther King",
          occupation = "activist",
          bio = "(1929 - 1968)  American civil rights campaigner"
        },
        new Guest
        {
          name = "Rosa Parks",
          occupation = "activist",
          bio = "(1913 - 2005)  American civil rights activist"
        },
        new Guest
        {
          name = "Peter Sellers",
          occupation = "entertainer",
          bio = "(1925 - 1980) British actor and comedian"
        },
        new Guest
        {
          name = "Alan Turing",
          occupation = "computer scientist",
          bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
        },
        new Guest
        {
          name = "Admiral Grace Hopper",
          occupation = "computer scientist",
          bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
        },
        new Guest
        {
          name = "Indira Gandhi",
          occupation = "politician",
          bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"
        },
      };

      return guests;

    }
    static void Main(string[] args)
    {
      List<Guest> guests = getGuests();
      Dictionary<string, List<Guest>> Tables = new Dictionary<string, List<Guest>>()
      {
        {"Table 1", new List<Guest>()},
        {"Table 2", new List<Guest>()}
      };

      foreach (Guest person in guests)
      {
        List<string> table1Occupations = new List<string>();
        foreach (Guest table1Guest in Tables["Table 1"])
        {
          table1Occupations.Add(table1Guest.occupation);
        }

        if (table1Occupations.Contains(person.occupation))
        {
          Tables["Table 2"].Add(person);
        }
        else
        {
          Tables["Table 1"].Add(person);
        }
      }

      foreach (KeyValuePair<string, List<Guest>> table in Tables)
      {
        Console.WriteLine(table.Key);
        foreach (Guest person in table.Value)
        {
          Console.WriteLine($"{person.name} {person.occupation} {person.bio}");
        }
      }
    }
  }
}
