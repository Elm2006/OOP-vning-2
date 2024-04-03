using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Namn
{
    private string förnamn;
    private string efternamn;

    public string Förnamn
    {
        get { return förnamn; }

        set { förnamn = value; }
    }
    public string Efternamn
    {
        get { return efternamn; }

        set { efternamn = value; }
    }
    public void FullNamn()
    {
        string helnamn = förnamn + " " + efternamn;
        Console.WriteLine(helnamn);
    }
}
