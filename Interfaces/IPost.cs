using System.Collections.Generic;
using Instadev_Perfil.Models;

namespace Instadev_Perfil.Interfaces
{
    public interface IPost
    {
         void RegisterPost(Post p);
         List<Post> ListarPosts();
         void DeletarPost(int id);
         void EditPost(Post p);
    }
}