using LProsud.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LProsud.Vista
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        //private object document;

        protected void Page_Load(object sender, EventArgs e)
        {
            //string usu;
            //if (!IsPostBack)
            //{
            //    if (Session["user"] == null)
            //    {
            //        System.Web.HttpContext.Current.Session["user"] = Session["user2"].ToString();
            //    }
            //    else
            //    {
            //        usu = Session["user"].ToString();
            //        System.Web.HttpContext.Current.Session["user2"] = usu;
            //    }

            //    if (Session["sessionBool"] == null || Session["sessionBool"].ToString() == "0")
            //    {
            //        FormsAuthentication.SignOut();
            //        Response.Redirect("Home.aspx");
            //    }
            //}

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

        public string ValidarEncabezadoFolio(int folio, string rut, int tipo)
        {
            conexion.Conexion conn = new conexion.Conexion();
            SqlCommand cmd = conn.ValidacionEncabezado(folio, rut, tipo);
            DataTable dt = new DataTable();
            string validacion = "";
            using (conn.procesadorabd())
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    validacion = row[0].ToString();
                }
                return validacion;
            }
        }

        public string ValidarEncabezadoFolioPrueba(int folio, string rut, int tipo)
        {
            conexion.Conexion conn = new conexion.Conexion();
            SqlCommand cmd = conn.ValidacionEncabezadoPrueba(folio, rut, tipo);
            DataTable dt = new DataTable();
            string validacion = "";
            using (conn.procesadorabdPrueba())
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    validacion = row[0].ToString();
                }
                return validacion;
            }
        }

        public void ProcesarDTEAcepto(int folio, string rut, int tipo, string fecha)
        {
            conexion.Conexion conn = new conexion.Conexion();
            SqlCommand cmd = conn.ProcesarDTEAcepto(folio, rut, tipo,fecha);
        }

        public void ProcesarDTEAceptoPrueba(int folio, string rut, int tipo, string fecha)
        {
            conexion.Conexion conn = new conexion.Conexion();
            SqlCommand cmd = conn.ProcesarDTEAceptoPrueba(folio, rut, tipo, fecha);
        }

        public void LogProcesar(string user, string log, int folio, string rut, int tipo)
        {
            conexion.Conexion conn = new conexion.Conexion();
            SqlCommand cmd = conn.LogProcesarDTE(user, log, folio, rut, tipo);
            DataTable dt = new DataTable();
        }

        public void LogProcesarPrueba(string user, string log, int folio, string rut, int tipo)
        {
            conexion.Conexion conn = new conexion.Conexion();
            SqlCommand cmd = conn.LogProcesarDTE(user, log, folio, rut, tipo);
            DataTable dt = new DataTable();
        }

        protected void proce(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3] {new DataColumn("folio", typeof(string)),
                            new DataColumn("detalle",typeof(string)),
            new DataColumn("estado",typeof(string))});
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox ch = (CheckBox)row.FindControl("Checkbox_sel");

                if (ch.Checked)
                {
                    string rut = row.Cells[1].Text;
                    string folio = row.Cells[3].Text;
                    string dte = row.Cells[11].Text;
                    string fecha = row.Cells[4].Text;

                    Image imaok = new Image();
                    Image imax = new Image();

                    imaok.ImageUrl = "~/Imagen/okicon.png";
                    imax.ImageUrl = "~/Imagen/xicon.png";

                    string detalle = ValidarEncabezadoFolio(Convert.ToInt32(folio), rut, Convert.ToInt32(dte));
                    //string detalle = ValidarEncabezadoFolioPrueba(Convert.ToInt32(folio), rut, Convert.ToInt32(dte));

                    if (detalle == "validacion correcta")
                    {                       
                        //prueba.Text = "validacion correcta";                        
                        try
                        {
                            //string fecha = fechaT.ToString("yyyy-MM-dd");
                            ProcesarDTEAcepto(Convert.ToInt32(folio), rut, Convert.ToInt32(dte), fecha);
                            //ProcesarDTEAceptoPrueba(Convert.ToInt32(folio), rut, Convert.ToInt32(dte), fecha);
                            dt.Rows.Add(folio, detalle, imaok.ImageUrl);
                        }
                        catch (Exception ex)
                        {
                            dt.Rows.Add(folio, "Error al Procesar:"+ ex, imax.ImageUrl);
                            throw;
                        }
                    }
                    else
                    {
                        dt.Rows.Add(folio, detalle, imax.ImageUrl);
                    }

                    LogProcesar(Session["user"].ToString(), detalle, Convert.ToInt32(folio), rut, Convert.ToInt32(dte));
                    //LogProcesarPrueba(Session["user"].ToString(), detalle, Convert.ToInt32(folio), rut, Convert.ToInt32(dte));

                }

            }
            GridView2.DataSource = dt;
            GridView2.DataBind();
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelDetalle').modal('show')", true);
        }

    }
}