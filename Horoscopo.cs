using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace RecupPoo.Entidades
{
    public static class Horoscopo
    {

        public static string SignoZodiaco(DateTime FechaNac)
        {
            return SignoSodiacal(FechaNac);
        }
        public static string SignoHoroscopoChino(int FechaNac)
        {
            if (FechaNac % 12==0)
            {
                return "MONO";
            }
            if (FechaNac % 12 == 1)
            {
                return "GALLO";
            }
            if (FechaNac % 12 == 2)
            {
                return "PERRO";
            }
            if (FechaNac % 12 == 3)
            {
                return "CERDO";
            }
            if (FechaNac % 12 == 4)
            {
                return "RATA";
            }
            if (FechaNac % 12 == 5)
            {
                return "BUEY";
            }
            if (FechaNac % 12 == 6)
            {
                return "TIGRE";
            }
            if (FechaNac % 12 == 7)
            {
                return "CONEJO";
            }
            if (FechaNac % 12 == 8)
            {
                return "DRAGON";
            }
            if (FechaNac % 12 == 9)
            {
                return "SERPIENTE";
            }
            if (FechaNac % 12 == 10)
            {
                return "CABALLO";
            }
            if (FechaNac % 12 == 11)
            {
                return "CABRA";
            }

            return "DATOS INVALIDOS";

        }
        private static string SignoSodiacal(DateTime FechaNac)
        {

            if ((FechaNac.Month == 12 && (FechaNac.Day >= 22 && FechaNac.Day <= 31) || (FechaNac.Day <=20)  && FechaNac.Month == 1))
            {
                return "CAPRICORNIO";
            }

            if ((FechaNac.Day >= 21 && FechaNac.Day <= 31) && FechaNac.Month == 1 || (FechaNac.Day <= 19 && FechaNac.Month == 2))
            {
                return "ACUARIO";
            }

            if (((FechaNac.Day >= 20 && FechaNac.Day<=31) && (FechaNac.Month == 2 ))|| FechaNac.Day<=20 &&  FechaNac.Month == 3)
            {
                return "PISCIS";
            }

            if ((FechaNac.Day >= 21 && FechaNac.Day <= 20) && (FechaNac.Month == 3 || FechaNac.Month == 4))
            {
                return "ARIES";
            }

            if ((FechaNac.Day >= 21) && (FechaNac.Day <= 31) && (FechaNac.Month == 4 )|| ((FechaNac.Day <= 21)&&FechaNac.Month == 5))
            {
                return "TAURO";
            }

            if ((FechaNac.Day >= 22 && FechaNac.Day <= 31 && FechaNac.Month == 5) || (FechaNac.Day <= 21 &&FechaNac.Month == 6))
            {
                return "GEMINIS";
            }

            if ((FechaNac.Day >= 22) && (FechaNac.Day <= 31) && (FechaNac.Month == 6) || (FechaNac.Day<=22)&&(FechaNac.Month == 7))
            {
                return "CANCER";
            }

            if ((FechaNac.Day >= 23) && (FechaNac.Day <= 31) && (FechaNac.Month == 7)||(FechaNac.Day<= 22) && (FechaNac.Month == 8))
            {
                return "LEO";
            }

            if (FechaNac.Day >= 23 && (FechaNac.Month == 8) || (FechaNac.Day <= 22) && (FechaNac.Month == 9))
            {
                return "VIRGO";
            }
            if (FechaNac.Day >= 23 && FechaNac.Day <= 31 && (FechaNac.Month == 9) || (FechaNac.Day <= 22 && FechaNac.Day <= 31 && (FechaNac.Month == 10)))
            {
                return "LIBRA";
            }
            if (FechaNac.Day >= 23 && FechaNac.Day <= 31 && (FechaNac.Month == 10) || (FechaNac.Day <= 22 && FechaNac.Day <= 31 && (FechaNac.Month == 11)))
            {
                return "ESCORPIO";

            }
            if (FechaNac.Day >= 23 && FechaNac.Day <= 31 && (FechaNac.Month == 11) || (FechaNac.Day <= 21 && (FechaNac.Month == 12)))
            {
                return "SAGITARIO";

            }

            return "DATOS INVALIDOS";
        }
    }
}
