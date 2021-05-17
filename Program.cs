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
  	/*	Rover[] arr = new Rover[] {lunokhod, apollo, sojourner};
      DirectAll(arr);
      Object[] allArr = new Object[] {lunokhod, apollo, sojourner, sputnik};

      foreach (Object o in allArr) {
        Console.WriteLine($"Tracking a {o.GetType()}");}
*/
        IDirectable[] directArr = new IDirectable[] {lunokhod, apollo, sojourner, sputnik};
      DirectAll(directArr);
    } 

    public static void DirectAll(IDirectable[] arr) {
      foreach (IDirectable a in arr) {
        Console.WriteLine(a.GetInfo());
        Console.WriteLine(a.Explore());
        Console.WriteLine(a.Collect());
      }
    }
  }
}
