namespace CondicionaisCSharp;

class Program
{
    static void Main(string[] args)
    {
        // int numero = 10;

        // if(numero > 0)
        // (
        //     Console.WriteLine("Número positivo");
        // )

        // Console.WriteLine("Número negativo");

        // Console.WriteLine("Digite um numero: ");
        // int numero = int.Parse(Console.ReadLine());

        // if(numero > 0)
        // {
        //     Console.WriteLine("Positivo");
        // }
        // else if (numero == 0)
        // {
        //     Console.WriteLine("O numero é negativo");
        // }
        // else
        // {
        //     Console.WriteLine("Negativo!");
        // }

        // Console.Write("Digite sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // if(idade < 16)
        // {
        //     Console.WriteLine("Não pode votar");
        // }
        // else if (idade < 18)
        // {
        //     Console.WriteLine("Voto opcional");
        // }
        // else
        // {
        //     Console.WriteLine("Voto obrigatorio");
        // }

        // Console.WriteLine("Digite uma nota:");
        // double nota = double.Parse(Console.ReadLine);

        // if(nota >= 7)
        // {
        //     Console.WriteLine("Aprovado");

        //     if(nota >= 9)
        //     {
        //         Console.WriteLine("Aprovado e ganhou estrelinha");
        //     }
        // }
        // else if (nota >= 5)
        // {
        //     Console.WriteLine("Recuperação");
        // }
        // else
        // {
        //     Console.WriteLine("Reprovado");
        // }

        // int n1 = 25;
        // int n2 = 5;

        // if(n1 > n2)
        // {
        //     Console.WriteLine("Primeiro(n1) é maior");
        // }
        // else if (n1 < n2)
        // {
        //     Console.WriteLine("Segundo(n2) é mairo");
        // }
        // else
        // {
        //     Console.WriteLine("Numeros iguais");
        // }




        // Console.Write("Usuario: ");
        // string usuario = Console.ReadLine();

        // Console.Write("Senha: ");
        // string senha ; Console.ReadLine;

        // if(usuario == "admin" && senha == "1234")
        // {
        //     Console.WriteLine("Acesso permitido.");
        // }
        // else
        // {
        //     Console.WriteLine("Acesso negado");
        // }


        // Console.WriteLine("Digite um numero:");
        // int numero = int.Parse(Console.ReadLine());

        // // if ternario
        // string resultado = numero % 2 == 0 ? "par" : "impar";

        // Console.WriteLine(resultado);

        // if (numero % 2 == 0)
        // {
        //     Console.WriteLine("Par!");
        // }
        // else
        // {
        //     Console.WriteLine("Impar!");
        // }


        // int idade = 12;

        // Console.WriteLine(idade >= 18 ? "Maior de idade" : "menor de idade");

        // Switch case
        // Console.Write("Digite um numero de 1 a 3; ");
        // int opcao = int.Parse(ReadLine());

        // switch (opcao)
        // {
            // case 1:
            //     Console.WriteLine("Você escolheu a opção 1.");
            //     break;
            // case 2:
            //     Console.WriteLine("Você escolheu a opção 2");
            //     break;
            // case 3:
            //     Console.WriteLine("Você escolheu a opção 3");
            //     break;
            // default:
            //     Console.WriteLine("Opção invalida");
            //     break;
        // 


        Console.Write("Digite uma opção: (A, B ou C): ");
        string opcao = Console.ReadLine();

        switch(opcao)
        {
            case "A":
                Console.WriteLine("Você escolheu a opção A.");
                break;
            case "B":
                Console.WriteLine("Você escolheu a opção B");
                break;
            case "C":
                Console.WriteLine("Você escolheu a opção C");
                break;
            default:
                Console.WriteLine("Opção invalida");
                break;}
    }   
}
