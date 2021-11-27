using DI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Classes
{
    public class OperacaoService
    {
        public OperacaoService(IOperacaoScoped operacaoScoped, IOperacaoSingleton operacaoSingleton, IOperacaoTransient operacaoTransient)
        {
            Scoped = operacaoScoped;
            Singleton = operacaoSingleton;
            Transient = operacaoTransient;
        }

        public IOperacaoScoped Scoped { get; set; }
        public IOperacaoSingleton Singleton { get; set; }
        public IOperacaoTransient Transient { get; set; }
    }
}
