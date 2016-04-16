﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftPV.Entities;
using SoftPV.API;
namespace SoftPV.BAL
{
    public class UserBAL
    {
        #region ATRIBUTOS 
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public List<int> groups { get; set; }
        public List<int> user_permissions { get; set; }
        public bool is_superuser { get; set; }
        public bool is_staff { get; set; }
        public bool is_active { get; set; }
        public string date_joined { get; set; }
        public string get_full_name { get; set; }
        #endregion
        public UserBAL()
        { }
        public UserBAL(int Id, string Username, string Password, string FirstName, string LastName, string Email, List<int> Groups, List<int> User_permissions,
            bool Is_superuser, bool Is_staff, bool Is_active,  string Date_joined, string Get_full_name)
        {
            this.id = Id;
            this.username = Username;
            this.password = Password;
            this.first_name = FirstName;
            this.last_name = LastName;
            this.email = Email;
            this.groups = Groups;
            this.user_permissions = User_permissions;
            this.is_superuser = Is_superuser;
            this.is_active = Is_active;
            this.is_staff = Is_staff;
            this.date_joined = Date_joined;
            this.get_full_name = Get_full_name;
        }

        public static bool AddUser(string Username, string Password, string First_name, string Last_name, string Email, List<int> Grupo,List<int> Permisos, bool Is_superuser,bool Is_staff, bool Is_active)
        {
            UserEntity userUserEntity = new UserEntity();
            userUserEntity.username = Username;
            userUserEntity.password = Password;
            userUserEntity.first_name = First_name;
            userUserEntity.last_name = Last_name;
            userUserEntity.groups = Grupo;
            userUserEntity.user_permissions = Permisos;
            userUserEntity.is_active = Is_active;
            userUserEntity.is_staff = Is_staff;
            userUserEntity.is_superuser = Is_superuser;
            UserAPI userapi = new UserAPI();
            return userapi.AddUser(userUserEntity);
        }
        public static bool IsLoginUs(string Usuario, string Contrasena)
        {
            UserAPI _UserAPI = new UserAPI();
          return  _UserAPI.AuthLogin(Usuario, Contrasena);
        }
        public static bool CheckMeUser()
        {
            UserAPI _UserAPI = new UserAPI();
            return _UserAPI.CkeckMeUser();
        }
        public static UserEntity Me()
        {
            UserAPI _UserAPI = new UserAPI();
            return _UserAPI.Me();
        }

        public bool IsLoginUs()
        {
            return IsLoginUs(this.username, this.password);
        }
        public void Yo()
        {
            UserEntity _user = new UserEntity();
            _user = Me();
            this.username = _user.username;
            this.get_full_name = _user.get_full_name;
        }
        public bool AddUser()
        {
            return AddUser(this.username, this.password, this.first_name, this.last_name, this.email, this.groups, this.user_permissions, this.is_superuser, this.is_staff, this.is_active);
        }

    }
}
