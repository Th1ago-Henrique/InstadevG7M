using System.Collections.Generic;
using Instadev_Perfil.Models;

namespace Instadev_Perfil.Interfaces
{
    public interface IUsuario
    {
         void CadastrarUsuario(Usuario u);
         void DeletarUsuario (int i);
         void EditarUsuario(Usuario u);
         List<Usuario> ListarUsuarios();
    }
}