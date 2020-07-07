using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestorSistemas.Models
{
    public class Marca
    {
        [Key]
        public int ID { get; set; }
        public string MarcaVeiculo { get; set; }
    }
}
