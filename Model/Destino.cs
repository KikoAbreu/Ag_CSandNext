using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace agborala.Model
{

    [Table("destino")]
    public class Destino
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; } = string.Empty;
        [Column("descricao")]
        public string Descricao { get; set; } = string.Empty;

        [Column("imgurl")]
        public string Imgurl { get; set; } = string.Empty;

    }
}