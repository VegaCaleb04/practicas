using System;

namespace pryCalculadoraPOO.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Calculadora Estructurada POO ***");
            //Definir Variables
            double dblValorA;
            double dblValorB;
            double dblValorC;
            string strOperacion;
            string strValidarDivision;
            //Inicializar Variables
            dblValorA = 0;
            dblValorB = 0;
            dblValorC = 0;
            strOperacion = "";
            strValidarDivision = "";
            //Ingresar Valores
            Console.WriteLine("Inicio Calculadora");
            Console.WriteLine("Ingrese Operacion +, -, *, /, Salir");
            strOperacion = Console.ReadLine();
            //Procesar Informacion
            while (!(strOperacion.ToString() == "Salir"))
            {
                if (
                    (strOperacion.Equals("+")) ||
                    (strOperacion.Equals("-")) ||
                    (strOperacion.Equals("*")) ||
                    (strOperacion.Equals("/"))
                    )
                {
                    Console.WriteLine("Ingrese Valor A");
                    dblValorA = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese Valor B");
                    dblValorB = Convert.ToDouble(Console.ReadLine());

                    //Suma
                    if ((strOperacion.Equals("+")))
                    {
                        //1. Operacion dentro del Main
                        dblValorC = dblValorA + dblValorB;
                        Console.WriteLine("Resultado Suma 1: " + dblValorC);

                        //Operacion dentro de la Clase Principal
                        dblValorC = fncSuma(dblValorA, dblValorB);
                        Console.WriteLine("Resultado Suma 2: " + dblValorC);

                        //Operacion fuera de la Clase Principal, dentro de una Clase Interna
                        clsCalculadoraInterna.fncSuma(dblValorA, dblValorB);
                        Console.WriteLine("Resultado Suma 4: " + dblValorC);

                        //Operacion fuera de la Clase Principal, dentro de una Clase Externa
                        clsCalculadoraExterna.fncSuma(dblValorA, dblValorB);
                        Console.WriteLine("Resultado Suma 4: " + dblValorC);
                    }

                    //Division
                    if ((strOperacion.Equals("/")))
                    {
                        //1. Operacion dentro del Main
                        dblValorC = dblValorA / dblValorB;
                        Console.WriteLine("Resultado Division 1: " + dblValorC);

                        //Operacion dentro de la Clase Principal
                        dblValorC = fncDivision(dblValorA, dblValorB, ref strValidarDivision);
                        Console.WriteLine("Resultado Division 2: " + dblValorC + " " + strValidarDivision);
                    }
                }
                else
                {
                    Console.WriteLine("Operacion No Valida");
                }
                Console.WriteLine("Ingrese Operacion +, -, *, /, Salir");
                strOperacion = Console.ReadLine();
            }
            Console.WriteLine("Fin Calculadora");
            Console.ReadLine();
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

    public class clsCalculadoraInterna
    {
        public clsCalculadoraInterna()
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
