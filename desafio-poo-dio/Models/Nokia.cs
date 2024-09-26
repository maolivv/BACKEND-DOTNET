using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo_dio.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;


        }
        public override void InstalarAplicativo(string nome)
        {
            
            Console.WriteLine($"{nome} está sendo instalado pelo Google Play.");
            
        }
    }
}