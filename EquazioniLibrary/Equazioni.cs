using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        static public bool IsDetermined(double a)
        {
            bool risposta = false;

            if (a != 0)
            {
                risposta = true;
            }

            return risposta;
        }
    }
}
