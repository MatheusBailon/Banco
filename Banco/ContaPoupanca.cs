using System;

namespace Banco
{
    // Herança com o sinal de dois pontos (:) indico que a classe ContaPoupanca Herda tudo da classe conta
    internal class ContaPoupanca : Conta
    {
        //override - indica que estamos sobrescrevendo o metodo da classe pai Conta q a classe ContaPoupanca herdou, ou seja, significa q esse metodo terá um outro tipo de comportamento aqui
        public override void Saca(double valor)
        {
            //O comando base indica que utilizaremos os dados da classe pai como base para codificar o nosso método
            //base.Saca(valor + 0.10);
            this.Saldo -= valor;
        }

        public override void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}