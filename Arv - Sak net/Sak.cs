using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sak
{
    protected string titel;
    protected string sak;

    public Sak ()
    {
        titel = "Untitled";
    }

    public void Print()
    {
        Console.WriteLine(sak + ", Namn: " + titel);
    }
   

}
