using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestorSistemas.Models
{
    public class Anuncio
    {
        [Key]
        public int ID { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string ValorCompra { get; set; }
        public string ValorVenda { get; set; }
        public string Cor { get; set; }
        public string Combustível { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime Date { get; set; }
    }
}
