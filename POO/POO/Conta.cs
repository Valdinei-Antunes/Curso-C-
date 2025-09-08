using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Conta
    {

        public String Nome { get; set; }
        private double Saldo { get; set; }
        public double Limite { get; private set; }
        public int Numero { get; set; }


        public void Depositar(double valor)
        {
            this.Saldo += valor;

        }

        public bool Sacar(double valor)
        {
            if (valor > this.ConsultaSaldoDisponivel()){
                Console.WriteLine("Saldo insuficiente");
                return false;

            }
             
            this.Saldo -= valor;
            return true;
        }

        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }
    }

}
