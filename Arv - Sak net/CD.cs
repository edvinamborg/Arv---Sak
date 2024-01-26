using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CD : Sak
{
    
    public CD(String namn)
    {
        titel = namn;
        sak = "CD";
        summary = sak + ", Namn: " + titel;
    }

    public override void Print()
    {
        Console.WriteLine(summary);
    }
}