using System;

namespace Banco
{
    public abstract class Conta
    {
        public int Numero { get; set; }

        //Quando uma classe eh declarada como abstract significa que ela não eh utilizada no código de maneira direta, ou seja, ela serve como base para as demais classes filhas

        //quando definimos o tipo de acesso como privete dizemos que o atributo pode ser alterado (set) ou visualizado (get) dentro da classe q o declarou
        //quando o tipo de acesso do atributo é protected ele é vizível (get) ou permite escrita (set) na classe que o declarou e nas suas subclasses através de herança.
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        //Quando um metodo eh declarado como abstract ele obriga uma implementação a mais nas subclasses
        public abstract void Deposita(double valor);

        public abstract void Saca(double valor);
        
    }
}