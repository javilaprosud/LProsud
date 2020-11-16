using LProsud.Modelo;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace LProsud.API
{
    public class APIJson
    {
        public bool estado;

        public string Post(string url, string json, string autorizacion = null)
        {
            estado = false;
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddHeader("APIKey", "rghaT6w0LI85rpZVdutRHxG27");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                if (autorizacion != null)
                {
                    request.AddHeader("Authorization", autorizacion);
                }

                IRestResponse response = client.Execute(request);

                string Respuesta = response.Headers[1].Value.ToString();

                estado = response.IsSuccessful;

                //dynamic datos = JsonConvert.DeserializeObject(response.Content);

                return Respuesta;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public dynamic Get(string url)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            //myWebRequest.CookieContainer = myCookie;
            myWebRequest.Credentials = CredentialCache.DefaultCredentials;
            myWebRequest.Proxy = null;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);
            //Leemos los datos
            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());

            dynamic data = JsonConvert.DeserializeObject(Datos);

            return data;
        }

        public Pedido Deserializar(string url)
        {
            string path = url;
            using (StreamReader jsonStream = new StreamReader(path, Encoding.Default))
            {
                var json = jsonStream.ReadToEnd();
                Modelo.Pedido ped = JsonConvert.DeserializeObject<Modelo.Pedido>(json);

                return ped;
            }
        }

    }
}