namespace PaginaCadastroBack.Models
{
    public class Usuario : InstadevBase, IUsuario
    {
        public string nomeCompleto { get; set; }
        
        public string nomeUsuario { get; set; }
        
        private string email { get; set; }
        
        private string senha { get; set; }
        
        private const string CAMINHO = "Database/usuario.csv";

        
    }
}