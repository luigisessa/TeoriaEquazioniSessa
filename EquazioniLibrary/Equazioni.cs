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

        static public bool IsInconsisted(double a, double b)
        {
            bool risposta = false;

            if (a == 0 && b != 0)
            {
                risposta = true;
            }

            return risposta;
        }

        static public bool IsIndetermined(double a, double b)
        {
            bool risposta = false;

            if (a == 0 && b == 0)
            {
                risposta = true;
            }

            return risposta;
        }

        static public bool IsDegree2(double a, double b, double c)
        {
            bool risposta = false;

            if (a != 0)
            {
                risposta = true;
            }

            return risposta;
        }

        static public double Delta(double a, double b, double c)
        {
            double delta;

            delta = (b * b) - 4 * (a) * (c);

            return delta;
        }

        static public string EquationDegree1(double a, double b)
        {
            string risposta = "";
            bool Determinato = IsDetermined(a);

            if (Determinato == true)
            {
                risposta = Convert.ToString(b / a);
            }

            bool Inconsisted = IsInconsisted(a, b);

            if (Inconsisted == true)
            {
                risposta = "Impossibile";
            }

            bool Indetermined = IsIndetermined(a, b);

            if (Indetermined == true)
            {
                risposta = "Indeterminato";
            }

            return risposta;
        }
    }
}
