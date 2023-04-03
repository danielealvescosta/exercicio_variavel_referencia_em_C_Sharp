using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipo_referencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contador obj1 = new Contador(); //cria um objeto tipo contador na memória

            Contador obj2 = null; //variável de referência pra um objeto do tipo contador - atribui valor nulo

            obj2 = obj1; //obj2 recebe o valor de referênia de obj1
            //variaveis de referencia guardam localizações de um objeto
            //obj1 e obj2 fazem referencia a um mesmo objeto

            obj1.incrementa(5);
            obj2.imprime();

            obj2.incrementa(10); //chama o método incrementa - valor = 10+10=20
            obj1.imprime();
        }//total de instancias(objetos criados) do tipo contador = 1
        //total de referencias para o objeto criado = 2 (obj1 e obj2)
    }
}
