using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bok : Sak
{
    private string författare;
    public Bok(String namn, String ff)
    {
        sak = "Bok";
        titel = namn;
        författare = ff;
        summary = sak + ", Namn: " + titel + ", Författare: " + författare;
    }

    
}