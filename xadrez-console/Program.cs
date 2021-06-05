using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try {

                /*PosicaoXadrez pos = new PosicaoXadrez('a', 1);
                Console.WriteLine(pos);

                Console.WriteLine(pos.toPosicao());*/


                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTela(partida.tab);

                    Console.WriteLine();

                    Console.WriteLine("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    Console.WriteLine();
                    partida.executaMovimento(origem, destino);
                }

                Tela.imprimirTela(partida.tab);

                Console.ReadLine();
            } catch (TabuleiroException e) {
                Console.WriteLine(e);
                Console.WriteLine();
            }



        }
    }
}
