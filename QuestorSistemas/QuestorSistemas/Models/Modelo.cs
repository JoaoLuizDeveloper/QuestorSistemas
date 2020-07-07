using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestorSistemas.Models
{
    public class Modelo
    {
        [Key]
        public int ID { get; set; }
        public string ModeloDetalhes { get; set; }
    }
}
