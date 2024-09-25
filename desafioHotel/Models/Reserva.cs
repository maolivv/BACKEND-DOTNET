using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace desafioHotel.Models
{
    public class Reserva
    {
        private List<Pessoa> Hospedes;
        private Suite Suite;
        public int DiasReservados;

        public void CadastrarHospedes(List<Pessoa> hospedes){
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite){ 
                Suite = suite;
        }

        public int ObterQuantidadeHospedes(){
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria(){
            decimal diariaTotal = Suite.ValorDiaria * DiasReservados;
            decimal desconto;
            if (DiasReservados >= 10){
                desconto = 0.10M;
                diariaTotal -= diariaTotal * desconto;
            }

            return diariaTotal;
        }
    }
}