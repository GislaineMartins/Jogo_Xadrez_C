using System;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();               

                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

    }




}
