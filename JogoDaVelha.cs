

using GameHub.View;

namespace GameHub
{
    public class JogoDaVelha : TelaJogoDaVelha
    {
        public bool fimDeJogo;
        public int quantidadePreenchida;
        public char vez;
        public JogoDaVelha()
        {
            fimDeJogo = false;
            vez = 'X';
            quantidadePreenchida = 0;
        }

        public void IniciarJogoDaVelha()
        {
            while (!fimDeJogo)
            {

                RenderizarTabela();
                LerEscolhaDoUsuario();
                RenderizarTabela();
                VerificarFimDeJogo();
                MudarVez();
            }
        }

        public void MudarVez()
        {
            vez = vez == 'X' ? 'O' : 'X';
        }


        public void VerificarFimDeJogo()
        {
            if (quantidadePreenchida < 5)
                return;

            if (ExisteVitoriaDiagonal() || ExisteVitoriaHorizontal() || ExisteVitoriaVertical())
            {
                fimDeJogo = true;
                Console.WriteLine($"Fim de jogo!!! Vitoria de {vez}");
                
                 
                return;
            }
            if (quantidadePreenchida is 9)
            {
                fimDeJogo = true;
                Console.WriteLine("Fim de jogo!!! EMPATE");
            }
        }
        public bool ExisteVitoriaHorizontal()
        {
            bool vitoriaLinha1 = posicao[0] == posicao[1] && posicao[0] == posicao[2];
            bool vitoriaLinha2 = posicao[3] == posicao[4] && posicao[3] == posicao[5];
            bool vitoriaLinha3 = posicao[6] == posicao[7] && posicao[6] == posicao[8];

            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;

        }
        public bool ExisteVitoriaVertical()
        {
            bool vitoriaLinha1 = posicao[0] == posicao[3] && posicao[0] == posicao[6];
            bool vitoriaLinha2 = posicao[1] == posicao[4] && posicao[1] == posicao[7];
            bool vitoriaLinha3 = posicao[2] == posicao[5] && posicao[6] == posicao[8];

            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;

        }
        public bool ExisteVitoriaDiagonal()
        {
            bool vitoriaLinha1 = posicao[2] == posicao[4] && posicao[2] == posicao[6];
            bool vitoriaLinha2 = posicao[0] == posicao[4] && posicao[0] == posicao[8];

            return vitoriaLinha1 || vitoriaLinha2;
        }
        public void LerEscolhaDoUsuario()
        {
            Console.WriteLine($"Agora é a vez de {vez}, entre uma posição de 1 a 9 que esteja disponível");
            bool conversao = int.TryParse(s: Console.ReadLine(), out int posicaoEscolhida);

            while (!conversao || !ValidarEscolhaUsuario(posicaoEscolhida))
            {
                Console.WriteLine("O campo escolhido é inválido. Por favor Escolha entreo número 1 e 9 na tabela.");
                conversao = int.TryParse(s: Console.ReadLine(), out posicaoEscolhida);

            }
            PreencherEscolha(posicaoEscolhida);
        }

        public void PreencherEscolha(int posicaoEscolhida)
        {
            int indice = posicaoEscolhida - 1;

            posicao[indice] = vez;
            quantidadePreenchida++;
        }

        public bool ValidarEscolhaUsuario(int posicaoEscolhida)
        {
            int indice = posicaoEscolhida - 1;

            return posicao[indice] != 'O' && posicao[indice] != 'X';

        }
        public void RenderizarTabela()
        {
            Console.Clear();
            Console.WriteLine(ObterTabela());
        }


    }
}
