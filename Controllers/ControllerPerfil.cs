using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Instadev_Perfil.Models;

namespace Instadev_Perfil.Controllers
{
    [Route("Perfil")]
    public class ControllerPerfil : Controller
    {
        Post publicacao = new Post();
        Usuario user = new Usuario();

        public IActionResult Index()
        {
            int id = int.Parse(HttpContext.Session.GetString("_Id"));
            List<Post> publi = publicacao.ListarPosts();
            List<Post> postagens = publi.FindAll(x => x.IdAutor == id);

            List<Usuario> users = user.ListarUsuarios();
            Usuario usuarioLogado = users.Find(y => y.Id == id);

            ViewBag.Posts = postagens;
            ViewBag.Perfil = usuarioLogado;
            
            return View();
        }
    }
}