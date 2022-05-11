using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjBanco
{
    internal class Banco
    {
        private int _conta;
        private string _nome;
        private double _saldo;

        public void Cadastro(int conta, string nome, double deposito)
        {
            _conta = conta;
            _nome = nome;

            if (deposito > 0)
            {
                _saldo = deposito;
            }
            

        }

        public void CadastroSemDeposito(int conta, string nome )
        {
            _conta = conta;
            _nome = nome;
            _saldo = 0;
                    
        }

        public int NumConta {
            get
            {
                return _conta;
            }
        }

        public string NomeTitular
        {
            get
            {
                return _nome;
            }
        }


        public double VerSaldo
        {
            get
            {
                return _saldo;
            }


        }

        public double Deposito
        {
            set
            {
                if (value > 0)
                {
                    _saldo += value;
                }
            }

        }

        public double Sacar
        {
            set
            {
                if (value > 0  && _saldo > 0)
                {
                    _saldo -= value  ;
                    _saldo -= 5;
                }
            }


        }

       
        public override string ToString()
        {
            return "Conta "+ NumConta 
                + " , Titular " + NomeTitular 
                + " , Saldo : " + VerSaldo ;
        }
    }
}