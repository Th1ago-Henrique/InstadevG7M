using System.Collections.Generic;
using InstaDevG7M.Models;

namespace InstaDevG7M.Interfaces
{
    public interface IUsuario
    {
         void Criar(Usuario u);

         List<Usuario> LerTodos();

         void Alterar(Usuario u);

         void Deletar(string Email);
    }
}