using GameHub.View;

namespace GameHub.Controllers
{
    public class OpcoesMenu
    {
        public static void MostrarMenu()
        {
   
            int opcao = 0;
            do
            {
                MenuInicial.Menu();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        break;

                    case 1:

                        ControleCredenciais verificar = new ControleCredenciais();
                        
                        verificar.VerificarLogin();
                        int escolha =0;
                        Console.Clear();

                       
                        
                        do
                        {
                            MenuLogado.Menu();
                          
                            escolha = int.Parse(Console.ReadLine());
                            
                            switch (escolha)
                            {

                                case 0:
                                    break;

                                case 1:
                                    new JogoDaVelha().IniciarJogoDaVelha();
                                    break;


                                case 2:

                                    break;
                                case 3:

                                    break;

                                default:

                                    break;

                            }
                            Console.Clear();
                        } while (escolha != 0);
                        break;
            
                    case 2:
                        
                        break;

                    default:
                        
                        break;

                }
                Console.Clear();
            } while (opcao != 0);
            
        }
     
    }
}
