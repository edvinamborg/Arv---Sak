using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Sak
{
    protected string titel;
    protected string sak;
    protected string summary;

    public Sak ()
    {
    }

    public abstract void Print();
   

}
