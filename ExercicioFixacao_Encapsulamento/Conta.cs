using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao_Encapsulamento
{
    class Conta
    {
        private int _numero;
        private string _nomeTitular;
        private double _montante; 

        public Conta (int numero, string nome)
        {
            _numero = numero;
            _nomeTitular = nome;
            _montante = 0.00;
        }

        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nomeTitular;
            }
            set
            {
                if (value != null)
                    _nomeTitular = value;
            }
        }

        public double Montante
        {
            get
            {
                return _montante;
            }
            set
            {
                _montante = value;
            }
        }

        public double Deposito(double montDeposito)
        {
            return _montante = _montante + montDeposito; 
        }

        public double Levantamento(double montLevantamamento)
        {
            return _montante = (_montante - montLevantamamento) - 5;  
        }

        public override string ToString()
        {
            return "Número de Conta: " + _numero+ "," + "\n"+
                   "Titular: " + _nomeTitular + "," + "\n" + 
                   "Saldo: " + _montante;
        }
    }
}
