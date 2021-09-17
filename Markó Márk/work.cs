using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markó_Márk
{
  class work
  {
    private string nev;

    public string Nev
    {
      get { return nev; }
      set { nev = value; }
    }
    private string nem;

    public string Nem
    {
      get { return nem; }
      set { nem = value; }
    }
    private string reszleg;

    public string Reszleg
    {
      get { return reszleg; }
      set { reszleg = value; }
    }

    private int belepev;

    public int Belepev
    {
      get { return belepev; }
      set { belepev = value; }
    }
    private int ber;

    public int Ber
    {
      get { return ber; }
      set { ber = value; }
    }
    public work(string nev, string nem, string reszleg, int belepev, int ber)
    {
      this.nev = nev;
      this.nem = nem;
      this.reszleg = reszleg;
      this.belepev = belepev;
      this.ber = ber;
    }
  }
}
