using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrilhaApiDesafio.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public EnumStatusTarefa Status { get; set; }
    }
}