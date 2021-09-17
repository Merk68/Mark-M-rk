using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Markó_Márk
{
  class Program
  {
    static List<work> lista = new List<work>(); 
    static void Main(string[] args)
    {
      ElsőFeladat();
      MásodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      Console.ReadLine();
    }

    private static void HetedikFeladat()
    {
      Console.WriteLine("7. feladat: Statisztika");
      Dictionary<string, int> stat = new Dictionary<string, int>()
      {
        { "beszerzés", 0},
        { "pénzügy", 0},
        { "asztalonműhely", 0},
        {"értékesítés", 0 },
        {"lakatosműhely", 0 },
        {"karbantartás", 0 },
        {"szerelőműhely", 0 },
        {"személyzeti", 0 }
      };
      {
        foreach (var s in stat)
        {

          Console.WriteLine($"{s.Key} - {s.Value}");
        }
      }

    }

    private static void HatodikFeladat()
    {
      
    }

    private static void OtodikFeladat()
    {
    }

    private static void NegyedikFeladat()
    {
      int osszeg = 0;
      int vegeredm = 0;
      foreach (var l in lista)
      {
        if (l.Belepev == 2020)
        {
          vegeredm = l.Ber / osszeg;
        }
        
      }
      Console.WriteLine($"4. feladat: {vegeredm}");
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine($"3. feladat: {lista.Count}");
    }

    private static void MásodikFeladat()
    {
      StreamReader olv = new StreamReader("berek2020.txt");
      olv.ReadLine();
      while (!olv.EndOfStream)
      {
        string[] a = olv.ReadLine().Split(';');
        lista.Add(new work(a[0], a[1], a[2], int.Parse(a[3]), int.Parse(a[4])));
      }
      olv.Close();
    }

    private static void ElsőFeladat()
    {
      
    }
  }
}
