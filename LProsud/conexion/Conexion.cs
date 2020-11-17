using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LProsud.conexion
{
    class Conexion
    {
        private bool ses;

        public SqlConnection procesadorabdPrueba()
        {
            SqlConnection sql_conexion = new SqlConnection(@"Data Source=10.0.0.10;Initial Catalog=procesadorabd_desarrollo;user=sa;pwd=Procesadora1");
            sql_conexion.Open();

            return sql_conexion;
        }

        public MySqlConnection mysqlIntranet()
        {
            MySqlConnection mysql_conn = new MySqlConnection("Database=oficinaprosud_appsprosud;Data Source=oficina.prosud.cl; User Id=oficinaprosud;Password=of.2102.cl");
            mysql_conn.Open();

            return mysql_conn;
        }

        public SqlConnection procesadoraAnalisis()
        {
            SqlConnection sql_conexion = new SqlConnection(@"Data Source=192.168.1.68;Initial Catalog=procesadora_analisis;user=sa;pwd=procesadora1");
            sql_conexion.Open();

            return sql_conexion;
        }

        public SqlConnection procesadorabd()
        {
            SqlConnection sql_conexion = new SqlConnection(@"Data Source=192.168.1.69;Initial Catalog=procesadorabd;user=sa;pwd=procesadora1");
            sql_conexion.Open();

            return sql_conexion;
        }

        public SqlConnection integracion()
        {
            SqlConnection sql_conexion = new SqlConnection(@"Data Source=172.16.200.5;Min Pool Size=0;Max Pool Size=10024;Pooling=true;Initial Catalog=integraciones;user=produccion;pwd=procesadora1");
            sql_conexion.Open();

            return sql_conexion;
        }

        //public void InsertarUsuario(string nombre, string clave, int admin, int codigo)
        //{
        //    using (procesadorabd())
        //    {
        //        SqlCommand cmd = new SqlCommand("SP_CreateUser", procesadorabd());
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add("@UsrsNombre", SqlDbType.VarChar).Value = nombre;
        //        cmd.Parameters.Add("@UsrsClave", SqlDbType.VarChar).Value = clave;
        //        cmd.Parameters.Add("@UsrsAdmin", SqlDbType.VarChar).Value = admin;
        //        cmd.Parameters.Add("@EmplCodigo", SqlDbType.VarChar).Value = codigo;
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        public SqlCommand DatosLogisticos()
        {
            using (integracion())
            {
                SqlCommand cmd = new SqlCommand("SP_DatosLogisticos", integracion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.BeginExecuteNonQuery();
                return cmd;
            }
        }
        public void DLogisticos()
        {
            using (integracion())
            {
                SqlCommand command = new SqlCommand("SP_DatosLogisticos", integracion());
                command.CommandTimeout = 0;
                command.ExecuteNonQuery();
            }
        }

        public void SPActOP()
        {
            try
            {

                using (integracion())
                {
                    SqlCommand command = new SqlCommand("SP_AppsProsud2", integracion());
                    command.CommandTimeout = 99999999;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void InsertarExcelDetalle(int mes, int anio, string nombreExcel)
        {
            using (procesadoraAnalisis())
            {
                SqlCommand cmd = new SqlCommand("SP_InsercionExcelDetalle", procesadoraAnalisis());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mes", SqlDbType.VarChar).Value = mes;
                cmd.Parameters.Add("@anio", SqlDbType.VarChar).Value = anio;
                cmd.Parameters.Add("@nombreExcel", SqlDbType.VarChar).Value = nombreExcel;
                cmd.ExecuteNonQuery();
            }
        }

        public string SP_Encabezado()
        {
            string query_SP;
            query_SP = "SP_ValidaDetalleAcepta";
            return query_SP;
        }

        public SqlCommand ValidacionEncabezado(int folio, string rut, int tipo)
        {
            using (procesadorabd())
            {
                SqlCommand cmd = new SqlCommand(SP_Encabezado(), procesadorabd());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@folio", SqlDbType.VarChar).Value = folio;
                cmd.Parameters.Add("@rut", SqlDbType.VarChar).Value = rut;
                cmd.Parameters.Add("@tipoDocumento", SqlDbType.VarChar).Value = tipo;
                cmd.ExecuteNonQuery();
                return cmd;
            }

        }

        public SqlCommand ValidacionEncabezadoPrueba(int folio, string rut, int tipo)
        {
            using (procesadorabdPrueba())
            {
                SqlCommand cmd = new SqlCommand(SP_Encabezado(), procesadorabdPrueba());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@folio", SqlDbType.VarChar).Value = folio;
                cmd.Parameters.Add("@rut", SqlDbType.VarChar).Value = rut;
                cmd.Parameters.Add("@tipoDocumento", SqlDbType.VarChar).Value = tipo;
                cmd.ExecuteNonQuery();
                return cmd;
            }

        }

        public string SP_Procesar()
        {
            string query_SP;
            query_SP = "SP_Procesar_DTE_Acepta";
            return query_SP;
        }

        public SqlCommand ProcesarDTEAcepto(int folio, string rut, int tipo, string fecha)
        {
            using (procesadorabd())
            {
                SqlCommand cmd = new SqlCommand(SP_Procesar(), procesadorabd());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tipodte", SqlDbType.VarChar).Value = tipo;
                cmd.Parameters.Add("@folio", SqlDbType.VarChar).Value = folio;
                cmd.Parameters.Add("@fchemision", SqlDbType.VarChar).Value = fecha;
                cmd.Parameters.Add("@rutemisor", SqlDbType.VarChar).Value = rut;
                cmd.ExecuteNonQuery();
                return cmd;
            }

        }

        public SqlCommand ProcesarDTEAceptoPrueba(int folio, string rut, int tipo, string fecha)
        {
            using (procesadorabdPrueba())
            {
                SqlCommand cmd = new SqlCommand(SP_Procesar(), procesadorabdPrueba());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tipodte", SqlDbType.VarChar).Value = tipo;
                cmd.Parameters.Add("@folio", SqlDbType.VarChar).Value = folio;
                cmd.Parameters.Add("@fchemision", SqlDbType.VarChar).Value = fecha;
                cmd.Parameters.Add("@rutemisor", SqlDbType.VarChar).Value = rut;
                cmd.ExecuteNonQuery();
                return cmd;
            }

        }

        public string SP_Log()
        {
            string query_SP;
            query_SP = "SP_Log_procesar_DTE";
            return query_SP;
        }

        public SqlCommand LogProcesarDTE(string user, string log, int folio, string rut, int tipo)
        {
            using (procesadorabd())
            {
                SqlCommand cmd = new SqlCommand(SP_Log(), procesadorabd());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("@detalle", SqlDbType.VarChar).Value = log;
                cmd.Parameters.Add("@folio", SqlDbType.VarChar).Value = folio;
                cmd.Parameters.Add("@rut", SqlDbType.VarChar).Value = rut;
                cmd.Parameters.Add("@dte", SqlDbType.VarChar).Value = tipo;
                cmd.ExecuteNonQuery();
                return cmd;
            }

        }

        public string SP_LogEnvioOP()
        {
            string query_SP;
            query_SP = "sp_EnvioOP_Log";
            return query_SP;
        }

        public SqlCommand logEnvioOP(string User_Log, string Descripcion_Log, string OP, string posicionesTotales)
        {
            using (procesadorabd())
            {
                SqlCommand cmd = new SqlCommand(SP_LogEnvioOP(), procesadorabd());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@User_Log", SqlDbType.VarChar).Value = User_Log;
                cmd.Parameters.Add("@Descripcion_Log", SqlDbType.VarChar).Value = Descripcion_Log;
                cmd.Parameters.Add("@OP", SqlDbType.VarChar).Value = OP;
                cmd.Parameters.Add("@posicionesTotales", SqlDbType.VarChar).Value = posicionesTotales;
                cmd.ExecuteNonQuery();
                return cmd;
            }

        }


        public SqlCommand LogProcesarDTEPrueba(string user, string log, int folio, string rut, int tipo)
        {
            using (procesadorabdPrueba())
            {
                SqlCommand cmd = new SqlCommand(SP_Log(), procesadorabdPrueba());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("@detalle", SqlDbType.VarChar).Value = log;
                cmd.Parameters.Add("@folio", SqlDbType.VarChar).Value = folio;
                cmd.Parameters.Add("@rut", SqlDbType.VarChar).Value = rut;
                cmd.Parameters.Add("@dte", SqlDbType.VarChar).Value = tipo;
                cmd.ExecuteNonQuery();
                return cmd;
            }
        }

        public string Valida_user(string user, string pass)
        {
            string query_SP;
            query_SP = "select (COUNT(*)) AS mybool  from users where password = '" + pass + "' and usuario='" + user + "' group by password, usuario";
            return query_SP;
        }

        public bool Ses(string user, string pass)
        {
            Conexion conn = new Conexion();

            DataTable dt = new DataTable();
            using (conn.mysqlIntranet())
            {
                MySqlCommand cmd = new MySqlCommand(conn.Valida_user(user, pass), conn.mysqlIntranet());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string text = row[0].ToString();
                    if (text == "1")
                    {
                        ses = true;
                    }
                    System.Web.HttpContext.Current.Session["sessionBool"] = text;
                }

                return ses;
            }

        }
    }
}