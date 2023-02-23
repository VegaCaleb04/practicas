using System;
using System.Collections.Generic;
using System.Text;

namespace pryCalculadoraPOO.ConsoleApp
{
    public class clsCalculadoraExterna
    {
        public clsCalculadoraExterna()
        {

        }

        public static double fncSuma(double dblValorA, double dblValorB)
        {
            return dblValorA + dblValorB;
        }

        public static double fncResta(double dblValorA, double dblValorB)
        {
            return dblValorA - dblValorB;
        }

        public static double fncMultiplicacion(double dblValorA, double dblValorB)
        {
            return dblValorA * dblValorB;
        }

        public static double fncDivision(double dblValorA, double dblValorB, ref string strValidarDivision)
        {
            double dblResultadoDivision = 0;
            if (fncValidacionDivision(dblValorA, dblValorB, ref strValidarDivision))
            {
                dblResultadoDivision = dblValorA / dblValorB;
            }
            else
            {
                dblResultadoDivision = 0;
            }
            return dblResultadoDivision;
        }

        public static bool fncValidacionDivision(double dblValorA, double dblValorB, ref string strValidarDivision)
        {
            bool blnValidarDividor = false;
            if ((dblValorA != 0) && (dblValorB != 0))
            {
                blnValidarDividor = true;
            }
            else
            if ((dblValorA != 0) && (dblValorB == 0))
            {
                strValidarDivision = "No se Puede Dividir entre cero";
                blnValidarDividor = false;
            }
            else
            if ((dblValorA == 0) && (dblValorB != 0))
            {
                strValidarDivision = "Resultado Indefinido";
                blnValidarDividor = false;
            }
            else
            if ((dblValorA == 0) && (dblValorB == 0))
            {
                strValidarDivision = "Resultado Indefinido";
                blnValidarDividor = false;
            }
            return blnValidarDividor;
        }
    }
}
