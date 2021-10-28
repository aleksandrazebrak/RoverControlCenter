using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957);
      
      //Rover[] rovers = {lunokhod, apollo, sojourner};

      //DirectAll(rovers);

      /* Object[] spaceProbes = {lunokhod, apollo, sojourner, sputnik};
      foreach (Object o in spaceProbes)
      {
        Console.WriteLine($"Tracking a {o.GetType()} for each one.");
      }*/

      IDirectable[] spaceProbes = {lunokhod, apollo, sojourner, sputnik};
      DirectAll(spaceProbes);

    }

    public static void DirectAll(IDirectable[] spaceProbes)
    {
      foreach (IDirectable r in spaceProbes)
      {
        Console.WriteLine(r.GetInfo());
        Console.WriteLine(r.Explore());
        Console.WriteLine(r.Collect());
      }
    }
  }
}
