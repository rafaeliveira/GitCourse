using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Conta
    {
        private string _nomeTitular;
        public int NumConta { get; private set; }
        public double Saldo { get; private set; }
        public Conta(string nomeTitular, int numConta)
        {
            _nomeTitular = nomeTitular;
            NumConta = numConta;
        }

        public Conta(string nomeTitular, int numConta, double depositoInicial) : this(nomeTitular, numConta)
        {
            Deposito(depositoInicial);
        }

        public string NomeTitular
        {
            get { return _nomeTitular; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nomeTitular = value;
                }
            }
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            double dTaxa = 5.0;

            if (quantia > 0)
            {
                Saldo -= quantia+dTaxa;
            }
        }

        public override string ToString()
        {
            return "|------------------------------"
                + "\n| Dados atualizados:\n"
                + "| Cliente: "
                + _nomeTitular
                + "\n| Conta: "
                + NumConta
                + "\n| Saldo Conta: R$ "
                + Saldo.ToString("F2")
                + " reais."
                + "\n|------------------------------";
        }
    }
}
