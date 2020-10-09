using System;

namespace helloWord.PasteTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            int variavelTeste;

            variavelTeste = 123;

            bool VariavelBoleana = false;

            if(VariavelBoleana == false)
                variavelTeste = 765;

            var TesteInteger = 111;
            var TesteBool =  true;
            var TesteString = "Aula";    

            Console.WriteLine("O Valor da Variavel é {0}", variavelTeste);
            Console.WriteLine("O Valor da Variavel é {0}", TesteInteger);
            Console.WriteLine("O Valor da Variavel é {0}", TesteBool);
            Console.WriteLine("O Valor da Variavel é {0}", TesteString);
            Console.ReadLine();
        }
    }
}
