using System;
using pryCalculadoraPOO.Model.Calculadora;

namespace pryCalculadoraPOO.Calculadora
{
    public class clsCalculadoraReferenciada : itfCalculadoraReferenciada
    {
        public int intValorA { get; set; }
        public int intValorB { get; set; }
        public int intResultado { get; set; }
        public double dblValorA { get; set; }
        public double dblValorB { get; set; }
        public double dblResultado { get; set; }
        public float flValorA { get; set; }
        public float fltValorB { get; set; }
        public float fltResultado { get; set; }
        public string strValidarDivision { get; set; }

        public clsCalculadoraReferenciada()
        {
            this.dblValorA = dblValorA;
            this.dblValorB = dblValorB;
            this.strValidarDivision = strValidarDivision;
            this.dblResultado = dblResultado;
        }
        public clsCalculadoraReferenciada(double dblValorA, double dblValorB)
        {
            this.dblValorA = dblValorA;
            this.dblValorB = dblValorB;
        }
        

        public double fncSuma()
        {
            return dblValorA + dblValorB;
        }
        public double fncSuma(Int32 intValorA, Int32 intValorB)
        {
            return intValorA + intValorB;
        }
        public double fncSuma(double dblValorA, double dblValorB)
        {
            return dblValorA + dblValorB;
        }
        public double fncSuma(float fltValorA, float fltValorB)
        {
            return fltValorA + fltValorB;
            
        }
        public static double fncSumastatic(Int32 intValorA, Int32 intValorB)
        {
            return intValorA + intValorB;
        }
        public static double fncSumastatic(double dblValorA, double dblValorB)
        {
            return dblValorA + dblValorB;
        }
        public static double fncSumastatic(float fltValorA, float fltValorB)
        {
            return fltValorA + fltValorB;

        }
        public  double fncSuma(mdlCalculadora objmdlSuma)
        {
            objmdlSuma.dblResultado = objmdlSuma.dblValorA + objmdlSuma.dblValorB;
            return objmdlSuma.dblResultado;

        }
      public mdlCalculadora fncSumaModel(mdlCalculadora objmdlSuma)
        {
            objmdlSuma.dblResultado = objmdlSuma.dblValorA + objmdlSuma.dblValorB;
            return objmdlSuma;

        }

        public  double fncResta()
        {
            return dblValorA - dblValorB;

        }
        public  double fncResta(Int32 intValorA, Int32 intValorB)
        {
            return intValorA - intValorB;

        }
        public double fncResta(float fltValorA, Int32 fltValorB)
        {
            return fltValorA - fltValorB;

        }
        public double fncResta(double dblValorA, double dblValorB)
        {
            return intValorA - intValorB;

        }
        public static double fncRestastatic(double dblValorA, double dblValorB)
        {
            return dblValorA - dblValorB;

        }
        public static double fncRestastatic(Int32 intValorA, Int32 intValorB)
        {
            return intValorA - intValorB;

        }
        public static double fncRestastatic(float fltValorA,float fltValorB)
        {
            return fltValorA - fltValorB;

        }

        public double fncMultiplicacion()
        {
            return dblValorA * dblValorB;
        }

        public double fncMultiplicacion(double dblValorA, double dblValorB)
        {
            return dblValorA * dblValorB;
        }
        public  double fncMultiplicacion(Int32 intValorA, Int32 intValorB)
        {
            return intValorA * intValorB;
        }
        public double fncMultiplicacion(float fltValorA, float fltValorB)
        {
            return fltValorA * fltValorB;
        }
        public static double fncMultiplicacionstatic(double dblValorA, double dblValorB)
        {
            return dblValorA * dblValorB;
        }
        public static double fncMultiplicacionstatic(int intValorA, int intValorB)
        {
            return intValorA * intValorB;
        }
        public static double fncMultiplicacionstatic(float fltValorA, float fltValorB)
        {
            return fltValorA * fltValorB;
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
        

        private static bool fncValidacionDivision(double dblValorA, double dblValorB, ref string strValidarDivision)
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
