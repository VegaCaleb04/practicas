using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PROYECTO_MESA_AYUDA2.Models;
namespace PROYECTO_MESA_AYUDA2.Controllers
{
    public class ControlArea
    {
        Area objArea;
        ControlConexion objControlConexion;
        public ControlArea(Area objArea)
        {
            this.objArea = objArea;
            objControlConexion=new ControlConexion(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BDMESA_AYUDA.mdf;Integrated Security = True");
            //objControlConexion = new ControlConexion(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\familiaCL\Documents\PROYECTO_MESA_AYUDA2\PROYECTO_MESA_AYUDA2\App_Data\BDMESA_AYUDA.mdf; Integrated Security = True");
        }
            
        public void guardar()
        {
            String id = objArea.IdArea;
            String nom = objArea.Nombre;
            String fke = objArea.FkEmple;

            
            objControlConexion.abrirBD();
            String cmSql = "INSERT INTO AREA(IDAREA,NOMBRE,FKEMPLE) VALUES('"+id+"','"+nom+"','"+fke+"')";
            //String cmSql = String.Format("INSERT INTO AREA(IDAREA,NOMBRE,FKEMPLE) VALUES('{0}','{1}','{2}')",id,nom,fke);
            //String cmSql = $"INSERT INTO AREA(IDAREA,NOMBRE,FKEMPLE) VALUES('{id}','{nom}','{fke}')";
            objControlConexion.ejecutarComandoSQL(cmSql);
            objControlConexion.cerrarBD();
        }
        public void modificar()
        {
            String id = objArea.IdArea;
            String nom = objArea.Nombre;
            String fke = objArea.FkEmple;


            objControlConexion.abrirBD();
            String cmSql = "UPDATE AREA SET NOMBRE='"+nom+ "',FKEMPLE='"+fke+"' WHERE IDAREA='"+id+"'";
            //String cmSql =String.Format("UPDATE AREA SET NOMBRE='{0}',FKEMPLE='{1}' WHERE IDAREA='{2}'",nom,fke,id);
            //String cmSql = $"UPDATE AREA SET NOMBRE='{nom}',FKEMPLE='{fke}' WHERE IDAREA='{id}'";
            objControlConexion.ejecutarComandoSQL(cmSql);
            objControlConexion.cerrarBD();
        }
        public void borrar()
        {
            String id = objArea.IdArea;
            objControlConexion.abrirBD();
            //String cmSql = "DELETE FROM AREA WHERE IDAREA='"+id+"'";
            String cmSql = String.Format("DELETE FROM AREA WHERE IDAREA='{0}'",id);
            //String cmSql = $"DELETE FROM AREA WHERE IDAREA='{id}'";
            objControlConexion.ejecutarComandoSQL(cmSql);
            objControlConexion.cerrarBD();
        }
        public Area consultar()
        {
            String id = objArea.IdArea;
            objControlConexion.abrirBD();
            //String cmSql = "SELECT * FROM AREA WHERE IDAREA='"+id+"'";
            //String cmSql = String.Format("SELECT * FROM AREA WHERE IDAREA='{0}'",id);
            String cmSql = $"SELECT * FROM AREA WHERE IDAREA='{id}'";
            DataSet objDataSet =objControlConexion.ejecutarConsultasSql(cmSql);
            objArea.Nombre = objDataSet.Tables[0].Rows[0][1].ToString();
            objArea.FkEmple = objDataSet.Tables[0].Rows[0][2].ToString();
            objControlConexion.cerrarBD();
            return objArea;
        }
    }
}