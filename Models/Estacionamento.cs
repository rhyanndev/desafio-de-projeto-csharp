using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamentoProjeto.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

        private List<string> veiculos = new List<string>();


        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(){
            
            //TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veículos"
            //Implemente aqui:
            Console.WriteLine("Digite a placa do veículo para estacionar");

            string placacarro;
            placacarro = Console.ReadLine()!;

            Console.WriteLine($"Você digitou: {placacarro}");

            Console.WriteLine("Veículo cadastrado!");

            veiculos.Add(placacarro);

        }

        public void RemoverVeiculo(){
            
            Console.WriteLine("Digite a placa do veículo para remover");

            //TODO: Pedir para o usuário digitar a placa e armazenar na variável placa

            string placa = "";

            //Verifica se o veículo existe
            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper())){

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado");

                // TODO: Pedir para o usuário digitar a quantidade de horas 
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valor
                //IMPLEMENTE AQUI

                int horas = 0;
                horas = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // TODO: Remover a placa dirigida da lista de veículos 
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");




            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se...");
            }

        }

        public void ListarVeiculos(){

            if(veiculos.Any()){


            Console.WriteLine("Listando veículos cadastrados:\n");

            foreach(string item in veiculos){

                Console.WriteLine($"Esse foi o veículo cadastrado: {item}\n");
            }
                }
            else{
                
                Console.WriteLine("Não há veículos estacionados.");
            }

        }
    
    }
}