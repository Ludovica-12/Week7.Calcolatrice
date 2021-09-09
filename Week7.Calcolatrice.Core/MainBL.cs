using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.Calcolatrice.Core
{
    public class MainBL
    {
        public double SommaNumeri(double n1, double n2)
        {
            return n1 + n2;
        }

        public double SottraiNumeri(double n1, double n2)
        {
            return n1 - n2;
        }

        public double MoltiplicaNumeri(double n1, double n2)
        {
            return n1 * n2;
        }

        /// <summary>
        /// Questo metodo fa la divisione tra X e Y e se Y = 0 restituisce null
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public double? DividiNumeri(double n1, double n2)
        {
            return (n2 == 0) ? null : (n1 / n2);
        }

        public bool VerificaSeAMaggioreDiB(double v1, double v2)
        {            
            return v1 >= v2;
        }

    }
}
