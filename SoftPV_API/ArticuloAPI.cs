using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftPV.Entities;
using RestSharp;
using RestSharp.Deserializers;
using System.Net;
using System.Data;
using System.ComponentModel;

namespace SoftPV.API
{
    public class ArticuloAPI
    {
        public bool AddArticulo(ArticuloEntity art)
        {


            var client = new RestClient(RutaBase.direccion);
            client.CookieContainer = new System.Net.CookieContainer();
            var request = new RestRequest("articulos/", Method.POST);
             request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "token " + Credencial.Token);
           // var json = request.JsonSerializer.Serialize(art);
           // request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            request.AddParameter("codigo",art.codigo);
            request.AddParameter("nombre",art.nombre);
            request.AddParameter("presentacion", art.presentacion);
            if (String.IsNullOrEmpty(art.img))
            { }
            else { request.AddFile("img", art.img); }
                
            
            request.AddParameter("medida", art.medida);
            request.AddParameter("precioPro", art.precioPro);
            request.AddParameter("precioPub", art.precioPub);
            request.AddParameter("descripcion", art.descripcion);
            request.AddParameter("existenciaMIN", art.existenciaMIN);
            request.AddParameter("proveedor", art.proveedor);

            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.Created)
            {

                return true;
            }

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                msError.ErrorMessage = response.Content.ToString();
                return false;
            }
            if (response.StatusCode == 0)
            {
                msError.ErrorMessage = "No es posible conectar con el servidor remoto";

                return false;
            }
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                msError.ErrorMessage = "No esta autorizado";
                return false;
            }
            if (response.StatusCode == HttpStatusCode.Forbidden)
            {
                msError.ErrorMessage = "Usted no tiene permisos.";
                return false;
            }
            msError.ErrorMessage = "----Error R21441 ----";
            return false;
        }
    }
}
