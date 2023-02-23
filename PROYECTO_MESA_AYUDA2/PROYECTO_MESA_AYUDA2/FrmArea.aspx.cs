using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROYECTO_MESA_AYUDA2.Models;
using PROYECTO_MESA_AYUDA2.Controllers;
namespace PROYECTO_MESA_AYUDA2
{
    public partial class FrmArea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            String nom = txtNombre.Text;
            String fke = txtFkEmple.Text;
            Area objArea = new Area(id, nom, fke);
            ControlArea objControlArea = new ControlArea(objArea);
            objControlArea.guardar();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            String nom = txtNombre.Text;
            String fke = txtFkEmple.Text;
            Area objArea = new Area(id, nom, fke);
            ControlArea objControlArea = new ControlArea(objArea);
            objControlArea.modificar();
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            Area objArea = new Area(id, "", "");
            ControlArea objControlArea = new ControlArea(objArea);
            objControlArea.borrar();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            String nom = "";
            String fke = "";
            Area objArea = new Area(id, nom, fke);
            ControlArea objControlArea = new ControlArea(objArea);
            objArea=objControlArea.consultar();
            txtNombre.Text = objArea.Nombre;
            txtFkEmple.Text = objArea.FkEmple;
        }
    }
}