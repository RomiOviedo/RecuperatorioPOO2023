using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RecupPoo.Entidades
{
    public class PrismaRectangularRecto
    {
        private int _altura;
        private int _ancho;

        private int _largo;

        private int AreaAltura()
        {
            return _altura * _ancho;
        }
        public int GetAreaAltura()
        {
            return AreaAltura();
        }
        private int AreaAncho()
        {
            return _altura * _largo;
        }
        public int GetAreaAncho()
        {
            return AreaAncho();
        }

        private int AreaBase()
        {
            return _largo * _ancho;
        }
        public int GetAreaBase()
        {
            return AreaBase();
        }

        //        La clase debe poder informar su área, su volumen y el valor de la diagonal.

        //      Área=2*(Ab+Ah+Aa) donde Ab es el área base, Ah es el área de la altura y Aa es el área del ancho.


        public int GetAltura()
        {
            return _altura;
        }

            public int GetAncho()
            {
                return _ancho;
            }
            public double GetArea()
            {
            return 2 * (AreaBase() + AreaAltura() + AreaAncho());
            }
        //         Diagonal=√(2&A^2+B^2+h^2 ), donde A es el largo, B es el ancho y h la altura.

        public double GetDiagonal()
            {
            return Math.Sqrt(Math.Pow(2 * _largo,2)+Math.Pow(_ancho,2)+Math.Pow(_altura, 2));
            }
            public int GetLargo()
            {
            return _largo;
            }
        //      Volumen=A* B*h, donde A es el largo, B es el ancho y h la altura.

        public double GetVolumen()
            {
            return _largo * _ancho * _altura;
            }


            public PrismaRectangularRecto()
            {
            }

            public PrismaRectangularRecto(int largo, int altura, int ancho)
            {
                if (largo <= 0 && altura <= 0 && ancho <= 0)
                {
                throw new ArgumentException("DATOS INVALIDOS");
                }
            _largo = largo;
            _altura = altura;
            _ancho = ancho;

            }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS PRIMA RECTANGULAR RECTO");
            sb.AppendLine($"ALTURA:{GetAltura()}");
            sb.AppendLine($"ANCHO:{GetAncho()}");
            sb.AppendLine($"LARGO:{GetLargo()}");
            sb.AppendLine($"AREA:{GetArea()}");
            sb.AppendLine($"DIAGONAL:{GetDiagonal()}");
            sb.AppendLine($"VOLUMEN:{GetVolumen()}");
            sb.AppendLine($"AREA BASE:{GetAreaBase()}");
            sb.AppendLine($"AREA ALTURA:{GetAreaAltura()}");
            sb.AppendLine($"AREA ANCHO:{GetAreaAncho()}");


            return sb.ToString();


        }




    }
}
