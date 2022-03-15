using System;

namespace ProEventos.Model
{
    public class Evento
    {
        public Guid EventoId { get; set; }
        public string Local { get; set; } 
        public DateTime DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemURL { get; set; }

        
    }
}