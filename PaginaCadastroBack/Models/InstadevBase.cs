namespace PaginaCadastroBack.Models
{
    public class InstadevBase
    {
        public Usuario(){
            CriarPastaEArquivo(CAMINHO);
        }

        private string PrepararLinha(Usuario u){
            return $"{u.Email};{u.Senha}";
        }
        
        public void CriarPastaEArquivo(string _caminho){
            
            string pasta = _caminho.Split("/")[0];
            string arquivo = _caminho.Split("/")[1];

            if (!Directory.Exists(pasta))   
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(_caminho))
            {
                File.Create(_caminho).Close();
            }
        }

        public void Criar(Usuario u)
        {
            string[] linha = {PrepararLinha(u)};
            File.AppendAllLines(CAMINHO, linha);
        }

        public List<Usuario> LerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string[] linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Usuario usuario = new Usuario();

                usuario.Email = linha[0];
                usuario.Senha = Int32.Parse(linha[1]);

                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public List<string> LerTodasLinhasCSV(string _caminho){

            List<string> linhas = new List<string>();
            using (StreamReader file = new StreamReader(_caminho))
            {
                string linha;
                while ((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }

            return linhas;
        }

        public void ReescreverCSV(string _caminho, List<string> linhas){

            using (StreamWriter output = new StreamWriter(_caminho))
            {
                foreach (var item in linhas)
                {
                    output.Write(item + "\n");
                }
            }
        }

        public void Alterar(Usuario u)
        {
            List<string> linhas = LerTodasLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == u.Email);
            linhas.Add(PrepararLinha(u));
            ReescreverCSV(CAMINHO, linhas);
        }

        public void Deletar(string Email)
        {
            List<string> linhas = LerTodasLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == Email);
            ReescreverCSV(CAMINHO, linhas);
        }
    }
    }
}