using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {

        public static bool isDetermined(double a, double b)
        {
            if (a != 0 && b != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsInconsisted(double a, double b)
        {
            if (a == b && a != b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsDegree2(double a)
        {
            if (a != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
        public static double Delta(double a,double b,double c)
        {
            return (b*b)-4*a*c;
        }
         
    }
}
