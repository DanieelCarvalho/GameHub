
namespace GameHub
{
    public class Jogador
    {
        public string Nome { get; private set; } 

        private string Senha {  get;  set; }
        public int Qvitorias { get; set; }

        public int Qderrotas { get; set; }

        public int Empates { get; set; }
   
        public Jogador(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public Jogador()
        {

        }
      
 
       
    }

    
        

              
            
}
