using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftPV.Entities;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using System.Net;
using System.Data;
using System.ComponentModel;

namespace SoftPV.API
{
    public class UserAPI
    {
        public bool AddUser(UserEntity user)
        {


            var client = new RestClient(RutaBase.direccion);
            client.CookieContainer = new System.Net.CookieContainer();
            var request = new RestRequest("usuarios/", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "token " + Credencial.Token);
            //var json = request.JsonSerializer.Serialize(user);
            //request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);

            //COMPROBACIÓN DE DATOS
            if (!string.IsNullOrEmpty(user.username))
            {
                request.AddParameter("username", user.username);
            }
            if (!string.IsNullOrEmpty(user.password))
            {
                request.AddParameter("password", user.password);
            }
            if (!string.IsNullOrEmpty(user.first_name))
            {
                request.AddParameter("first_name", user.first_name);
            }
            if (!string.IsNullOrEmpty(user.last_name))
            {
                request.AddParameter("last_name", user.last_name);
            }
            if (!string.IsNullOrEmpty(user.email))
            {
                request.AddParameter("email", user.email);
            }
            for (int con = 0; con < user.groups.Count; con++)
            {
                request.AddParameter("groups", user.groups.ElementAt(con));
            }
          
            request.AddParameter("is_superuser", user.is_superuser);
            request.AddParameter("is_staff", user.is_staff);
            request.AddParameter("is_active", user.is_active);
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
        public bool UpdateUser(UserEntity user)
        {


            var client = new RestClient(RutaBase.direccion);
            client.CookieContainer = new System.Net.CookieContainer();
            var request = new RestRequest("usuarios/" + user.id + "/", Method.PATCH);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "token " + Credencial.Token);
            //var json = request.JsonSerializer.Serialize(user);
            //request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);

            //COMPROBACIÓN DE DATOS
            if (!string.IsNullOrEmpty(user.username))
            {
                request.AddParameter("username", user.username);
            }
            if (!string.IsNullOrEmpty(user.password))
            {
                request.AddParameter("password", user.password);
            }
            if (!string.IsNullOrEmpty(user.first_name))
            {
                request.AddParameter("first_name", user.first_name);
            }
            if (!string.IsNullOrEmpty(user.last_name))
            {
                request.AddParameter("last_name", user.last_name);
            }
            if (!string.IsNullOrEmpty(user.email))
            {
                request.AddParameter("email", user.email);
            }
            for (int con = 0; con < user.groups.Count; con++)
            {
                request.AddParameter("groups", user.groups.ElementAt(con));
            }

            request.AddParameter("is_superuser", user.is_superuser);
            request.AddParameter("is_staff", user.is_staff);
            request.AddParameter("is_active", user.is_active);
            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {

                return true;
            }
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
        public bool AuthLogin(string username, string password)
        {
            var client = new RestClient(RutaBase.direccion);
            client.Authenticator = new SimpleAuthenticator("username", username, "password",password);
            client.CookieContainer = new System.Net.CookieContainer();
            var request = new RestRequest("token/", Method.POST);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
                Token _Token = new Token();
                _Token = deserial.Deserialize<Token>(response);
                Credencial.Token = _Token.token;
                return true;
            }
            if (response.StatusCode == 0)
            {
                msError.ErrorMessage = "No es posible conectar con el servidor remoto";
                return false;
            }
            if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    msError.ErrorMessage = "Por favor introduza nombre de usuario y contraseña correctos de una cuenta asignada. Note que puede que ambos campos sean estrictos en relación a diferencias entre mayúsculas y minúsculas.";
                    return false;
                }
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    msError.ErrorMessage = "Nombre de usuario/contraseña inválidos.";
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
        public bool CkeckMeUser()
        {
            var client = new RestClient(RutaBase.direccion);

            var request = new RestRequest("usuarios/me/", Method.HEAD);
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
        public bool ChangePassword(int Id, string Pass1, string Pass2)
        {
            var client = new RestClient(RutaBase.direccion);

            var request = new RestRequest("usuarios/"+Id+ "/set_password/", Method.POST);
            request.AddHeader("Authorization", "token " + Credencial.Token);
            if (!string.IsNullOrEmpty(Pass1))
            {
                request.AddParameter("password1", Pass1);
            }
            if (!string.IsNullOrEmpty(Pass2))
            {
                request.AddParameter("password2", Pass2);
            }
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
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                msError.ErrorMessage = response.Content.ToString(); 
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
        public UserEntity  Me()
        {
            UserEntity _UserEntity = new UserEntity();
            var client = new RestClient(RutaBase.direccion);
            client.CookieContainer = new System.Net.CookieContainer();
            var request = new RestRequest("usuarios/me/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "token " + Credencial.Token);

            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
                _UserEntity = deserial.Deserialize<UserEntity>(response);
                
            }

            return _UserEntity;   

        }
        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            var client = new RestClient(RutaBase.direccion);
            client.CookieContainer = new System.Net.CookieContainer();
            var request = new RestRequest("usuarios/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "token " + Credencial.Token);

            var response = client.Execute(request);
            List<UserEntity> _userEntity;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
                _userEntity = deserial.Deserialize<List<UserEntity>>(response);
                dt = ConvertToDataTable(_userEntity);
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
        public UserEntity GetOneUser(int Id)
        {
            UserEntity user = new UserEntity();

            var client = new RestClient(RutaBase.direccion);
            client.CookieContainer = new System.Net.CookieContainer();
            var request = new RestRequest("usuarios/" + Id + "/", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "token " + Credencial.Token);

            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
                user = deserial.Deserialize<UserEntity>(response);

                return user;
            }

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                msError.ErrorMessage = response.Content.ToString();
                user.id = 0;
                return user;
            }
            if (response.StatusCode == 0)
            {
                msError.ErrorMessage = "No es posible conectar con el servidor remoto";
                user.id = 0;
                return user;
            }
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                msError.ErrorMessage = "No esta autorizado";
                user.id = 0;
                return user;
            }
            if (response.StatusCode == HttpStatusCode.Forbidden)
            {
                msError.ErrorMessage = "Usted no tiene permisos.";
                user.id = 0;
                return user;
            }
            msError.ErrorMessage = "----Error R21441 ----";
            user.id = 0;
            return user;

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
