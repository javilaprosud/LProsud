using LProsud.Modelo;
using Newtonsoft.Json;
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
    public partial class EnvioOP : System.Web.UI.Page
    {
        static Pedido ped = new Pedido();
        public string usu;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("http://oficina.prosud.cl");
                }
                else
                {
                    System.Web.HttpContext.Current.Session["user2"] = usu;
                    if (Session["user"].ToString() == "")
                    {
                        usu = Session["user2"].ToString();
                    }
                    else
                    {
                        usu = Session["user"].ToString();
                    }
                }

                if (Session["sessionBool"] == null || Session["sessionBool"].ToString() == "0")
                {
                    FormsAuthentication.SignOut();
                    Response.Redirect("http://oficina.prosud.cl");
                }
            }
        }
        public void logEnvioOP(string User_Log, string Descripcion_Log, string OP, string posicionesTotales)
        {
            conexion.Conexion conn = new conexion.Conexion();
            SqlCommand cmd = conn.logEnvioOP(User_Log, Descripcion_Log, OP, posicionesTotales);
            //DataTable dt = new DataTable();
        }
        public void cargarGrid()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.AddRange(new DataColumn[6] {
                            new DataColumn("Posi", typeof(string)),
                            new DataColumn("Sku", typeof(string)),
                            new DataColumn("Desc",typeof(string)),
                            new DataColumn("Cant",typeof(string)),
                            new DataColumn("Uni",typeof(string)),
                            new DataColumn("Esp", typeof(string)),
            });

            foreach (var item in ped.Items)
            {
                string Posi = item.Posicion;
                string Sku = item.SKU;
                string Desc = item.Descripcion;
                string Cant = item.Cantidad;
                string Uni = item.UNIDAD;
                string Esp = item.Especial1;

                dt2.Rows.Add(Posi, Sku, Desc, Cant, Uni, Esp);
            }
            GridItems.DataSource = dt2;
            GridItems.DataBind();
        }

        public bool dataOP()
        {
            try
            {
                API.APIJson APIJ = new API.APIJson();
                string url = "\\\\172.16.200.5\\MLIntegracion\\NVX10_" + nOP.Value + "_2020" + mes.Value + ".json";

                ped = APIJ.Deserializar(url);

                cargarGrid();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void headers()
        {
            IDKey.Text = "IDKey: " + ped.IDKey;
            Cliente.Text = "Cliente: " + ped.Cliente;
            Documento.Text = "Documento: " + ped.Documento;
            FechaPedido.Text = "Fecha Pedido: " + ped.FechaPedido;
            FechaDespacho.Text = "Fecha Despacho: " + ped.FechaDespacho;
            NombreCli.Text = "Nombre Cliente: " + ped.NombreCli;
            DireccionCli.Text = "Direccion Cliente: " + ped.DireccionCli;
            ComunaCli.Text = "Comuna Cliente: " + ped.ComunaCli;
            RutCli.Text = "Rut Cliente: " + ped.RutCli;
            txtTotalPosi.Text = ped.TotalPosiciones;
            AliasBodega.Text = "Alias Bodega: " + ped.AliasBodega;
            Observacion.Text = "Observacion: " + ped.Observacion;
        }

        protected void AnalisisOP(object sender, EventArgs e)
        {
            try
            {
                if (dataOP())
                {
                    headers();
                    ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelPedido').modal('show')", true);
                }
                else
                {
                    img.ImageUrl = "~/Imagen/xicon.png";
                    LblRespuesta.Text = "Error al acceder al documento";
                    ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelDetalle').modal('show')", true);
                }
            }
            catch (Exception ex)
            {
                img.ImageUrl = "~/Imagen/xicon.png";
                LblRespuesta.Text = "OP no encontrada";
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelDetalle').modal('show')", true);
            }
        }

        //protected void GridItems_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    GridItems.EditIndex = e.NewEditIndex;
        //    //refresh();
        //    //dataOP();
        //    //ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelPedido').modal('show')", true);
        //}

        //public void refresh()
        //{
        //    Page.Response.Redirect(Page.Request.Url.ToString(), true);
        //    dataOP();
        //    ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelPedido').modal('show')", true);
        //}

        //protected void GridItems_RowCancelEdit(object sender, GridViewCancelEditEventArgs e)
        //{
        //    GridItems.EditIndex = -1;
        //    ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelPedido').modal('show')", true);
        //}

        //protected void GridItems_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        //{
        //    int i = e.RowIndex;
        //    object control = GridItems.Rows[i].FindControl("txtProdID");
        //    //string id = e.RowIndex.ToString();
        //    //int posi = Convert.ToInt32(id) + 1;
        //    //foreach (var item in ped.Items)
        //    //{
        //    //    if (item.Posicion == posi.ToString())
        //    //    {
        //    //        //string prueba = e.NewValues.Values[0].toString(); 
        //    //    }
        //    //}

        //    //ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelPedido').modal('show')", true);

        //}

        //protected void UpdatePanel1_Load(object sender, EventArgs e)
        //{
        //    dataOP();
        //    ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelPedido').modal('show')", true);
        //}



        //protected void edit_Click1(object sender, EventArgs e)
        //{
        //    dataOP();
        //    ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelPedido').modal('show')", true);
        //}

        protected void GridItems_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            int posi = index;
            int i = 0;
            foreach (var item in ped.Items)
            {
                //int posItem = Convert.ToInt32(item.Posicion);
                if (i == posi)
                {
                    ped.Items = ped.Items.Where((val, idx) => idx != index).ToArray();
                    updTotales(Convert.ToString(Convert.ToDecimal(ped.TotalPosiciones) - 1));
                }
                if (i > posi)
                {
                    item.Posicion = Convert.ToString(i);
                }
                i++;
            }

            cargarGrid();
            headers();
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelPedido').modal('show')", true);
        }

        public void updTotales(string numero)
        {
            ped.TotalPosiciones = numero;
            headers();
        }

        public void resizeTotal(int cant)
        {
            List<Items> prueba = ped.Items.ToList();
            for (int i = 0; i < cant; i++)
            {
                Items it = new Items
                {
                    Cantidad = "",
                    Descripcion = "",
                    Especial1 = "",
                    Posicion = "",
                    SKU = "",
                    UNIDAD = ""
                };
                prueba.Add(it);
            }
            ped.Items = prueba.ToArray();
            updTotales(txtTotalPosi.Text);
        }

        protected void BtnUPDTotales_Click(object sender, EventArgs e)
        {
            decimal actualTotal = Convert.ToDecimal(ped.TotalPosiciones);
            decimal newtotal = Convert.ToDecimal(txtTotalPosi.Text);
            if (newtotal < 100 && actualTotal < newtotal)
            {
                int cantidad = Convert.ToInt32(newtotal) - Convert.ToInt32(actualTotal);
                resizeTotal(cantidad);
                updTotales(txtTotalPosi.Text);
                cargarGrid();
            }

            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelPedido').modal('show')", true);
        }

        protected void EnvioPedido(object sender, EventArgs e)
        {
            string usu2;
            if (Session["user"].ToString() == "")
            {
                usu2 = Session["user2"].ToString();
            }
            else
            {
                usu2 = Session["user"].ToString();
            }
            try
            {

                int i = 0;
                foreach (GridViewRow item in GridItems.Rows)
                {
                    ped.Items[i].Posicion = (item.FindControl("txtPosi") as TextBox).Text;
                    ped.Items[i].SKU = (item.FindControl("txtSKU") as TextBox).Text;
                    ped.Items[i].Descripcion = (item.FindControl("txtDesc") as TextBox).Text;
                    ped.Items[i].Cantidad = (item.FindControl("txtCantidad") as TextBox).Text;
                    ped.Items[i].UNIDAD = (item.FindControl("txtUnidad") as TextBox).Text;
                    ped.Items[i].Especial1 = (item.FindControl("txtEspecial") as TextBox).Text;

                    i = i + 1;
                }

                API.APIJson APIJ = new API.APIJson();
                //Pedido ped = APIJ.Deserializar();
                string json = JsonConvert.SerializeObject(ped);
                string ret = APIJ.Post("http://190.153.223.174:82/Api/IngresarPedido", json);

                LblRespuesta.Text = ret;

                if (APIJ.estado)
                {
                    img.ImageUrl = "~/Imagen/okicon.png";
                }
                else
                {
                    img.ImageUrl = "~/Imagen/xicon.png";
                }

                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelDetalle').modal('show')", true);
                logEnvioOP(usu2, ret, ped.Documento, ped.TotalPosiciones);
            }
            catch (Exception ex)
            {
                img.ImageUrl = "~/Imagen/xicon.png";
                LblRespuesta.Text = ex.ToString();
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "$('#ModelDetalle').modal('show')", true);
                logEnvioOP(usu2, ex.ToString(), ped.Documento, ped.TotalPosiciones);
            }
        }


    }
}