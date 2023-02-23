using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using pryCalculadoraPOO.Calculadora;
using pryCalculadoraPOO.Model.Calculadora;

namespace pryCalculadoraPOO.WindowApp
{
    public partial class wfmCalculadoraPOO : Form
    {
        clsCalculadoraReferenciada objCalculadoraReferenciada = new clsCalculadoraReferenciada();
        double dblValorA, dblVAlorB;


        public wfmCalculadoraPOO()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double dblValorA = 0;
            double dblValorB = 0;
            double dblResultado = 0;
            //validar Numeros
            if (!string.IsNullOrWhiteSpace(txtValorA.Text) && !string.IsNullOrWhiteSpace(txtValorB.Text))
            {
                //validar Digitos
                if (char.IsDigit(txtValorA.Text, 0) && char.IsDigit(txtValorB.Text, 0))
                {
                    try
                    {

                        dblValorA = Convert.ToDouble(txtValorA.Text);
                        dblValorB = Convert.ToDouble(txtValorB.Text);
                        // atributos globales a la clase metodos unico
                        clsCalculadoraReferenciada objcalculadoraresferenciada1 = new clsCalculadoraReferenciada();
                        objcalculadoraresferenciada1.dblValorA = dblValorA;
                        objcalculadoraresferenciada1.dblValorB = dblValorB;
                        dblResultado = objcalculadoraresferenciada1.fncSuma();

                        // Atributos Globales al constructor con unico Metodo
                        clsCalculadoraReferenciada objCalculadoraReferenciada2 = new clsCalculadoraReferenciada();
                        dblResultado = objCalculadoraReferenciada2.fncSuma();

                        // Atributo especifico al metodo estatico
                        dblResultado = clsCalculadoraReferenciada.fncSumastatic(dblValorA, dblValorB);

                        // Atributos Especificos al metodo con Metodo Sobrecarga
                        clsCalculadoraReferenciada objcalculadorareferenciada3 = new clsCalculadoraReferenciada();
                        dblResultado = objcalculadorareferenciada3.fncSuma(dblValorA, dblValorB);
                        txtResultado.Text = dblResultado.ToString();

                        //interfaz
                        itfCalculadoraReferenciada objitfcalculadoraReferenciada4 = new clsCalculadoraReferenciada();
                        dblResultado = objitfcalculadoraReferenciada4.fncSuma(dblValorA, dblValorB);
                        // modelo
                        itfCalculadoraReferenciada objitfCalculadoraRefenciada5 = new clsCalculadoraReferenciada();
                        mdlCalculadora objmdlCalculadora = new mdlCalculadora();
                        objmdlCalculadora.dblValorA = dblValorA;
                        objmdlCalculadora.dblValorB = dblVAlorB;
                        dblResultado = objitfCalculadoraRefenciada5.fncSuma(objmdlCalculadora);

                        itfCalculadoraReferenciada objitfCalculadoraRefenciada6 = new clsCalculadoraReferenciada();
                        objmdlCalculadora= objitfCalculadoraRefenciada6.fncSumaModel(objmdlCalculadora);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Suma fallida", "ok");
                        lblValidacion.Text = ex.Message;
                    }
                    finally
                    {
                        MessageBox.Show("Suma Exitosa", "ok");
                        txtResultado.Text = dblResultado.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Campos Ingresados No Son Digitos", "validacion");
                }
            }
            else
            {
                MessageBox.Show("Campos Ingresados Vacios o Nulos", "validacion");
            }
            

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double dblValorA = 0;
            double dblValorB = 0;
            double dblResultado = 0;

            dblValorA = Convert.ToDouble(txtValorA.Text);
            dblValorB = Convert.ToDouble(txtValorB.Text);
            
           
            clsCalculadoraReferenciada objCalculadoraReferenciada = new clsCalculadoraReferenciada();
            txtResultado.Text = objCalculadoraReferenciada.fncMultiplicacion(dblValorA, dblValorB).ToString();

    

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double dblValorA = 0;
            double dblValorB = 0;
            double dblResultado = 0;
            dblValorA = Convert.ToDouble(txtValorA.Text);
            dblValorB = Convert.ToDouble(txtValorB.Text);

            clsCalculadoraReferenciada objCalculadoraReferenciada = new clsCalculadoraReferenciada();
            txtResultado.Text = objCalculadoraReferenciada.fncResta(dblValorA, dblValorB).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double dblValorA = 0;
            double dblValorB = 0;
            double dblResultado = 0;
            string strValidarDivision = "";
            dblValorA = Convert.ToDouble(txtValorA.Text);
            dblValorB = Convert.ToDouble(txtValorB.Text);

            clsCalculadoraReferenciada objCalculadoraReferenciada = new clsCalculadoraReferenciada();
            txtResultado.Text = clsCalculadoraReferenciada.fncDivision(dblValorA, dblValorB, ref strValidarDivision).ToString();
            
        }

        private void lblValidacion_Click(object sender, EventArgs e)
        {

        }
    }
}
