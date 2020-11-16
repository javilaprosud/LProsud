using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LProsud.Vista
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                conexion.Conexion conn = new conexion.Conexion();
                bool session = conn.Ses(Request.QueryString["username"], Request.QueryString["password"]);
                
                try
                {
                    if (Request.QueryString["username"] == null)
                    {
                        string u = Session["user2"].ToString();
                        if (Session["user2"] != null)
                        {
                            System.Web.HttpContext.Current.Session["user"] = Session["user2"].ToString();
                        }
                    }
                    else
                    {
                        System.Web.HttpContext.Current.Session["user"] = Request.QueryString["username"];
                        System.Web.HttpContext.Current.Session["user2"] = Request.QueryString["username"];
                    }                    
                    
                }
                catch (Exception ex)
                {
                    System.Web.HttpContext.Current.Session["user"] = Request.QueryString["username"];
                }

                if (Session["sessionBool"] == null || Session["sessionBool"].ToString() == "0")
                {
                    Response.Write("<script>alert('Error: Sesión caducada.')</script>");
                    Response.Redirect("http://oficina.prosud.cl");
                }
            }

        }
    }
}