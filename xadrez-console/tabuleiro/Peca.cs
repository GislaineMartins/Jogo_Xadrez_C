using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro {
    class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qtdMovimentos { get; set; }
        public int MyProperty { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab) {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this.qtdMovimentos = 0;
        }
    }
}
