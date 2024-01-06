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
            Console.WriteLine("Digite a placa do veículo para estacionar\n");

            string placa = Console.ReadLine()!;

            if (!string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Você digitou: " + placa);
                veiculos.Add(placa);
                Console.WriteLine("Veículo cadastrado!");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Você não digitou nada ou digitou apenas espaços em branco.");
                Thread.Sleep(3000);
                Console.Clear();

            }
        }
        public void RemoverVeiculo(){
            
            Console.WriteLine("Digite a placa do veículo para remover\n");

            //TODO: Pedir para o usuário digitar a placa e armazenar na variável placa

            string placa = Console.ReadLine()!;

            if (!string.IsNullOrEmpty(placa)){

                //Verifica se o veículo existe
                if(veiculos.Any(x => x.ToUpper() == placa.ToUpper())){

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado\n");

                int horas = int.Parse(Console.ReadLine()!);

                decimal valorTotal = precoInicial + (precoPorHora * horas);
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            
                }
                else
                    {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se...");
                }
            }
            else{
                Console.WriteLine("Você não digitou nada ou digitou apenas espaços em branco.");
                Thread.Sleep(3000);
                Console.Clear();
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
