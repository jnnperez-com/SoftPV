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
    public class PermisoAPI
    {
        public bool AddPermiso(PermisoEntity grupo)
        {


            var client = new RestClient(RutaBase.direccion);
            client.CookieContainer = new System.Net.CookieContainer();
            var request = new RestRequest("permisos/", Method.POST);
            //request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "token " + Credencial.Token);
            var json = request.JsonSerializer.Serialize(grupo);
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);

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
        public DataTable GetAllPermisos()
        {
            DataTable dt = new DataTable();

            var client = new RestClient(RutaBase.direccion);
            client.CookieContainer = new System.Net.CookieContainer();
            var request = new RestRequest("permisos/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "token " + Credencial.Token);

            var response = client.Execute(request);
            List<PermisoEntity> _PermisoEntity;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
                _PermisoEntity = deserial.Deserialize<List<PermisoEntity>>(response);
                dt = ConvertToDataTable(_PermisoEntity);
                return dt;
            }

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                msError.ErrorMessage = response.Content.ToString();
                return dt;
            }
            if (response.StatusCode == 0)
            {
                msError.ErrorMessage = "No es posible conectar con el servidor remoto";

                return dt;
            }
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                msError.ErrorMessage = "No esta autorizado";
                return dt;
            }
            if (response.StatusCode == HttpStatusCode.Forbidden)
            {
                msError.ErrorMessage = "Usted no tiene permisos.";
                return dt;
            }
            msError.ErrorMessage = "----Error R21441 ----";
            return dt;

        }
        public List<PermisoEntity> GetAllPermisosList()
        {
            List<PermisoEntity> _PermisoEntity = null;


            var client = new RestClient(RutaBase.direccion);
            client.CookieContainer = new System.Net.CookieContainer();
            var request = new RestRequest("permisos/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "token " + Credencial.Token);

            var response = client.Execute(request);
           
            if (response.StatusCode == HttpStatusCode.OK)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
                _PermisoEntity = deserial.Deserialize<List<PermisoEntity>>(response);
                return _PermisoEntity;
            }

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                msError.ErrorMessage = response.Content.ToString();
                return _PermisoEntity;
            }
            if (response.StatusCode == 0)
            {
                msError.ErrorMessage = "No es posible conectar con el servidor remoto";

                return _PermisoEntity;
            }
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                msError.ErrorMessage = "No esta autorizado";
                return _PermisoEntity;
            }
            if (response.StatusCode == HttpStatusCode.Forbidden)
            {
                msError.ErrorMessage = "Usted no tiene permisos.";
                return _PermisoEntity;
            }
            msError.ErrorMessage = "----Error R21441 ----";
            return _PermisoEntity;

        }
        public bool CkeckMePermisos()
        {
            var client = new RestClient(RutaBase.direccion);

            var request = new RestRequest("permisos/", Method.HEAD);
            request.AddHeader("Authorization", "token " + Credencial.Token);

            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;

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
        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            // table.TableName = "Proveedores";

            return table;

        }
    }
}
