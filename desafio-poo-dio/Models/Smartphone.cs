using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo_dio.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar(){
            Console.WriteLine($"discando...");
            
        }

        public void ReceberLigacao(){
            Console.WriteLine($"recebendo ligação...");
            
        }

        public abstract void InstalarAplicativo(string nome);
    }
}