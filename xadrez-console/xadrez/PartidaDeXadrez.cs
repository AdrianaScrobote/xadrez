using System;
using tabuleiro;

namespace xadrez {
    class PartidaDeXadrez {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez() {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino) {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas() {
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('a', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('b', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('f', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('g', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('h', 1).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('a', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('b', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('f', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('g', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('h', 8).toPosicao());
        }
    }
}
