using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Vincenzi
{
    internal class Libro
    {


        public string toString(string autore, string titolo, string anno, string editore, string numeroPg)    // metodo toString
        {

            autore += " ";
            titolo += " ";
            anno += " ";
            editore += " ";
            numeroPg += " ";


            return autore + titolo + anno + editore + numeroPg;
        }


        public string readTime(int numPag)    // metodo readTime
        {
            string durata = "2h";
            if (numPag < 100)
            {
                durata = "1h";


            }
            if (numPag > 200)
            {

                durata = "+ di 2h";


            } 
            

            return durata;
        }










    }
}
