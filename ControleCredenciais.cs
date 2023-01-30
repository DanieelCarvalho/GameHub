using Newtonsoft.Json;


namespace GameHub
{
    public  class ControleCredenciais 
    {
        public readonly string _pathLogin = "./Data/Login.json";
        

        public string JsonLogin()
        {
            return File.ReadAllText(_pathLogin) ;
        }


        public bool VerificarLogin()
        {
            bool usuarioLogado = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite seu usuário: ");
                string usuario = Console.ReadLine()!;
                Console.WriteLine("Digite sua senha: ");
                string senha = Console.ReadLine()!;

                List<Login> repositorioLogin = JsonConvert.DeserializeObject<List<Login>>(JsonLogin())!;

               

                foreach (var login in repositorioLogin)
                {
                    if (login.Usuario == usuario && login.Senha == senha)
                    {
                        Console.WriteLine($"Bem vindo {login.Usuario}");
                        
                        usuarioLogado = true;
                        break;
                    }


                }
        
                if (!usuarioLogado)
                {
                    Console.WriteLine("Usuário não encontrado!");
                }
                
            } while (!usuarioLogado);

            return true;
        }



    }
}
