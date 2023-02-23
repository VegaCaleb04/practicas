using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryDatosPersonalesCalebVega.Model;
using pryDatosPersonalesCalebVega.BusinessRule;

namespace pryDatosPersonalesCalebVega.WinForm
{
    public partial class wfmDatosPersonales : Form
    {
        public wfmDatosPersonales()
        {
            InitializeComponent();
        }


        private void btnDatosPersonales_Click(object sender, EventArgs e)
        {
            fncDatosPersonales();
        }
        public void fncDatosPersonales()
        {
            mdlDatosPersonales objmdlDatosPersonales = new mdlDatosPersonales();
            objmdlDatosPersonales.nombre = txtNombre.Text;
            objmdlDatosPersonales.apellido = txtApellido.Text;
            objmdlDatosPersonales.documento= txtDocumento.Text;

            itfDatosPersonales objitfDatosPersonales = new clsDatosPersonales();
            objmdlDatosPersonales= objitfDatosPersonales.fncDatosPersonales(objmdlDatosPersonales);

            txtResultado.Text = objmdlDatosPersonales.retorno;

        }
    }
}
