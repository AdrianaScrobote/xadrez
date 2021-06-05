using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try {

                PosicaoXadrez pos = new PosicaoXadrez('a', 1);
                Console.WriteLine(pos);

                Console.WriteLine(pos.toPosicao());
                /*Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 3));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

                Tela.imprimirTela(tab);

                Console.ReadLine();*/
            } catch (TabuleiroException e) {
                Console.WriteLine(e);
                Console.WriteLine();
            }



        }
    }
}
