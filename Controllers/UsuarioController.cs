using System;
using InstaDevG7M.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDevG7M.Controllers
{
    [Route("Usuario")]
    public class UsuarioController : Controller
    {
        Usuario usuarioModel = new Usuario();

        [Route("Listar")]
        public IActionResult Index(){

            ViewBag.Usuario = usuarioModel.LerTodos();

            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form){
            Usuario novoUsuario = new Usuario();
            novoUsuario.Email = form["Email"];
            novoUsuario.Senha = Int32.Parse(form["Senha"]);

            usuarioModel.Criar(novoUsuario);

            ViewBag.Usuarios = usuarioModel.LerTodos();

            return LocalRedirect("~/Usuario/Listar");
        }
    }
}