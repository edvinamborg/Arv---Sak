using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DVD : Sak
{
    
    public DVD(String i)
    {
        titel = i;
        sak = "DVD";
        summary = sak + ", Namn: " + titel;
    }

    public override void Print()
    {
        Console.WriteLine(summary);
    }
}