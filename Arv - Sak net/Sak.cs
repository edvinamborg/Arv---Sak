using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sak
{
    protected string titel;
    protected string sak;
    protected string summary;

    public Sak ()
    {
    }

    public void Print()
    { 
        Console.WriteLine(summary);       
    }
   

}
