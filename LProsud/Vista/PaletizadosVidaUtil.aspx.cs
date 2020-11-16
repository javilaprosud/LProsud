using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LProsud.Vista
{
    public partial class PaletizadosVidaUtil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usu;
            if (!IsPostBack)
            {
                if (Session["user"] == null)
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
        bool SaveFile(string name, FileUpload file, string savePath)
        {
            try
            {
                string fileName = file.FileName;

                savePath += name;
                file.SaveAs(savePath);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool sp_datosLogisticos()
        {
            conexion.Conexion c = new conexion.Conexion();
            try
            {
                c.DLogisticos();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        protected void cargarPalletizadosVidaUtil(object sender, EventArgs e)
        {
            try
            {
           
                if (SaveFile("datos.csv", FileUploadPalletizados, "\\\\INTEGRACION\\DatosLogisticos\\Paletizado\\"))
                {
                    if (SaveFile("vida.csv", FileUploadVidaUtil, "\\\\INTEGRACION\\DatosLogisticos\\VidaUtil\\"))
                    {

                        if (sp_datosLogisticos())
                        {
                            img.Visible = true;
                            img.ImageUrl = "~/Imagen/okicon.png";
                            LblRespuesta.Text = "Proceso será notificado mediante correo";
                            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelDetalle').modal('show')", true);
                        }
                        else
                        {
                            img.Visible = true;
                            img.ImageUrl = "~/Imagen/xicon.png";
                            LblRespuesta.Text = "Error al procesar el proceso SP";
                            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelDetalle').modal('show')", true);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                img.ImageUrl = "~/Imagen/xicon.png";
                LblRespuesta.Text = "Error al procesar";
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelDetalle').modal('show')", true);                
            }            
        }

    }
}