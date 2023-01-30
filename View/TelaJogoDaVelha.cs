
namespace GameHub.View
{
    public  class TelaJogoDaVelha
    {
        public char[] posicao { get; set; }

        public TelaJogoDaVelha()
        {
            posicao = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        }



        public string ObterTabela()
        {
            Console.WriteLine();
            return $"__{posicao[0]}__|__{posicao[1]}__|__{posicao[2]}__\n" +
                    $"__{posicao[3]}__|__{posicao[4]}__|__{posicao[5]}__\n" +
                    $"  {posicao[6]}  |  {posicao[7]}  |  {posicao[8]}  \n\n";
        }


    }
}
