﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Entities;
namespace BussinessLogic
{
    public class UsuarioLogic
    {
        UsuarioDAL dal = new UsuarioDAL();

        public List<Usuario> UsuarioLista()
        {
            var listUsuario = dal.GetUsuariosList();
            return listUsuario;
        }

        public Usuario Login(string email, string password)
        {
            Usuario user = dal.Login(email, password);
            return user;
        }

        public bool EditarNombre(int userId,string nombre,string email,string password)
        {
            Usuario user = new Usuario();
            user.UsuarioID = userId;
            user.Nombre = nombre;
            user.Email = email;
            user.Password = password;
            bool status = dal.EditarNombre(user);
            return status;

        }

        public bool EditarEmail(int id,string nombre,string email,string password)
        {
            Usuario user = new Usuario();
            user.UsuarioID = id;
            user.Nombre = nombre;
            user.Email = email;
            user.Password = password;
            bool status = dal.EditarEmail(user);
            return status;
        }

        public bool EditarPassword(int id, string nombre, string email, string password)
        {
            Usuario user = new Usuario();
            user.UsuarioID = id;
            user.Nombre = nombre;
            user.Email = email;
            user.Password = password;
            bool status = dal.EditarEmail(user);
            return status;

        }

        public bool RegistrarUsuario(string nombre, string email,string password)
        {
            Usuario user = new Usuario();
            user.Nombre = nombre;
            user.Email = email;
            user.Password = password;
            bool status = dal.RegistrarUsuario(user);
            return status;
        }
    }
}