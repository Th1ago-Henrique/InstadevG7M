namespace PaginaCadastroBack.Interfaces
{
    public interface IUsuario
    {
        void Criar(Usuario u);

         List<Usuario> LerTodas(); 
    }
}