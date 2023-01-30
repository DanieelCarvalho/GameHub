namespace GameHub
{
    public class Login 
    {

        //private readonly string arquivoJson = @"C:\Users\calda\Documents\Sharp codes\GameHub\GameHub\Data\Jogadores.json";

        public string Usuario { get; private set; }

        public string Senha { get; private set; }

        public Login( string usuario, string senha)
        {  
            Usuario = usuario;
            Senha = senha;
        }
    }

}
