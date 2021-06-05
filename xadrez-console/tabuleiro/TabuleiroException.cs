using System;
using tabuleiro;

namespace tabuleiro {
    class TabuleiroException : Exception {

        public TabuleiroException(string msg): base(msg) {}
    }
}
