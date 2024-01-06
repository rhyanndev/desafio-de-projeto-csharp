
using System.Diagnostics;
using estacionamentoProjeto.Models;

//Encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;

decimal precoPorHora = 0;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!\n");


Console.WriteLine("Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());


Console.WriteLine("Digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());


// Console.WriteLine("Digite uma opção:\n");
// Console.WriteLine("1 - Cadastrar veículo\n");
// Console.WriteLine("2 - Remover veículo\n");
// Console.WriteLine("3 - Listar veículo\n");
// Console.WriteLine("4 - Encerrar\n");

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

void exibirMenu(){



    Console.WriteLine("Digite uma opção:\n");
    Console.WriteLine("1 - Cadastrar veículo\n");
    Console.WriteLine("2 - Remover veículo\n");
    Console.WriteLine("3 - Listar veículo\n");
    Console.WriteLine("4 - Encerrar\n");

    int numero = int.Parse(Console.ReadLine());


    switch(numero)
    {
        case 1:
            es.AdicionarVeiculo();
        break;
        case 2:
            es.RemoverVeiculo();
        break;
        case 3:
            es.ListarVeiculos();
        break;

        default:
            Console.WriteLine("Número não reconhecido.");
        break;
    }



}

exibirMenu();




