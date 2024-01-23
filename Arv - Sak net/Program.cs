using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv___Sak_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Databas minDatabas = new Databas();
            minDatabas.Add(new DVD("kung fury"));
            minDatabas.Add(new CD("Lord of the Rings"));
            minDatabas.Add(new DVD("Matrix"));
            minDatabas.Add(new Bok("Great Gatsby", "F Scott Fitzgerald"));
            minDatabas.Add(new DVD("Titanic"));
            minDatabas.Add(new CD("Avatar"));
            minDatabas.Add(new Bok("Harry Potter", "J.K Rowling"));
            minDatabas.SkrivUt();
        }
    }
}
