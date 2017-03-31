using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader reader = new StreamReader("nomes_telefones.txt");
            //TextReader tr = new StreamReader(@"C:\Users\...\Desktop\Test.txt"); 
            String linha = reader.ReadLine();
            while (linha != null)
            {

                Console.WriteLine(linha.ToString().Replace(")", "").Replace("(", "").Replace("-", ""));
                linha = reader.ReadLine();

            }

            Console.ReadKey();
        }
    }
}
