using System;
using System.Collections.Generic;
using System.Text;
using pryCalculadoraPOO.Model.Calculadora;

namespace pryCalculadoraPOO.Calculadora
{
    public interface itfCalculadoraReferenciada
    {

       double dblValorA { get; set; }
        double dblValorB { get; set; }
        double dblResultado { get; set; }
        string strValidarDivision { get; set; }
        double fncSuma();
        double fncSuma(Int32 intValorA, Int32 intValorB);
        double fncSuma(double dblValorA, double dblValorB);
       double fncSuma(float fltValorA, float fltValorB);


        double fncSuma(mdlCalculadora objmdlCalcladora);
       mdlCalculadora fncSumaModel(mdlCalculadora objmdlCalcladora);
    }

}
