using DI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Classes
{
    public class Operacao : IOperacaoScoped , IOperacaoSingleton, IOperacaoTransient
    {
        public Operacao() : this(Guid.NewGuid())
        {
        }

        public Operacao(Guid operacaoId)
        {
            OperacaoId = operacaoId;
        }

        public Guid OperacaoId { get; private set; }

    }
}
