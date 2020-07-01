using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }

        public override bool[,] MovimentoPossiveis()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
