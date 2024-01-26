using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Databas
{
    private List<Sak> saker;

    public Databas()
    {
        saker = new List<Sak>();
    }

    public void Add(Sak ensak)
    {
        saker.Add(ensak);
    }

    public void SkrivUt()
    {
        foreach (Sak sak in saker)
        {           
            sak.Print();
        }
    }
}