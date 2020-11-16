using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LProsud.Vista
{
    public partial class ActualizacionOP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string usu;
                if (!IsPostBack)
                {
                    if (Session["user"].ToString() != "snavarrete")
                    {
                        Response.Redirect("http://oficina.prosud.cl");
                    }
                    else
                    {
                        usu = Session["user"].ToString();
                        System.Web.HttpContext.Current.Session["user2"] = usu;
                    }

                    if (Session["sessionBool"] == null || Session["sessionBool"].ToString() == "0")
                    {
                        FormsAuthentication.SignOut();
                        Response.Redirect("http://oficina.prosud.cl");
                    }
                }
            }
            catch (Exception ex)
            {

                FormsAuthentication.SignOut();
                Response.Redirect("http://oficina.prosud.cl");
            }
           
        }

        public bool ActOP()
        {
            conexion.Conexion c = new conexion.Conexion();
            try
            {
                c.SPActOP();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        protected void BtnAc_Click(object sender, EventArgs e)
        {

            try
            {
                if (ActOP())
                {
                    LblRespuesta.Text = "Proceso ejecutándose, se anotificará por correo.";                    
                }
                else
                {
                    LblRespuesta.Text = "Error al procesar";
                }
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModalDetalle').modal('show')", true);
            }
            catch (Exception ex)
            {
                LblRespuesta.Text = "Error al ejecutar: " + ex;
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModalDetalle').modal('show')", true);
            }


        }
    }
}