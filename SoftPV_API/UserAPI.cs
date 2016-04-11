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

namespace SoftPV.API
{
    public class UserAPI
    {
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
                    msError.ErrorMessage = "No puede iniciar sesión con las credenciales proporcionadas.";
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
    }
}
