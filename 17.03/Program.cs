using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _17._03
{
  class Program
  {
    static void Main(string[] args)
    {
      Type console = typeof(Console);
      MethodInfo[] methods = console.GetMethods();
      Console.WriteLine("Список методов класса Console: \n");
      foreach (MethodInfo m in methods)
      {
        Console.Write(m.ReturnType.Name + "\t" + m.Name);
        Console.Write("\n");
      }
      Console.ReadLine();
    }
  }
}
