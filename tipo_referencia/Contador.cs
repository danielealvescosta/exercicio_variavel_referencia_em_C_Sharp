using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipo_referencia
{
    internal class Contador
    {
        private int valor; //atributo
        public Contador() //construtor para inicializar os atributos
        {
            valor = 5;
        }

        public void incrementa (int incremento)//chama o método incrementa - valor = 5+5=10
        {
            valor += incremento;
        }

        public void imprime()//chama o método imprime
        {
            Console.WriteLine("Valor: {0}", valor);
        }
    }
}
