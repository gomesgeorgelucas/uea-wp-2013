using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta("Lucas", 01, 100);
            Conta conta2 = new Conta("George", 02);
            conta1.AlteraNome("Begnini");
            conta2.Saque(10);
            conta2.Saque(10);
            conta1.Deposito(100);
            conta2.Deposito(50);
            Console.WriteLine("O saldo da conta do:"+ conta1.getNome() +"é:"+ conta1.Saldo);
            Console.WriteLine("O saldo da conta do:" + conta2.getNome() + "é:" + conta2.Saldo);
            Console.ReadKey();
        }
    }
}
