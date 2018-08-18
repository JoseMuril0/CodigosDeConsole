using System;

namespace CodigosConsoles
{
    class DivisaoPorZeroException : Exception
    {
        public DivisaoPorZeroException(string mensagem) : base(mensagem)
        {

        }
    }
}
