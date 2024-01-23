using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CD : Sak
{
    
    public CD(String namn)
    {
        titel = namn;
        sak = "CD";
        summary = sak + ", Namn: " + titel;
    }
}