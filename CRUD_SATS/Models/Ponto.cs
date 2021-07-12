using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRUD_SATS.Models
{
    [Table("Pontos")]
    class Ponto
    {
        [Key]
        public int IDPonto { get; set; }
        [StringLength(50)]

        public string NomePonto { get; set; }
        [StringLength(100)]

        public string EndereçoPonto { get; set; }
        [StringLength(50)]

        public string NomeMedidor { get; set; }
        [ForeignKey("Macro")]
        public int Macro_ID { get; set; }
        public Macro Macro { get; set; }
        public ICollection<ConfigVaz> ConfigVazs { get; set; }
        public ICollection<ConfigNv> ConfigNvs { get; set; }
        public ICollection<ConfigBomba> ConfigBombas { get; set; }
    }
    [Table("Macros")]
    class Macro
    {   [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string NomeMacro { get; set; }
        public ICollection<Ponto> Pontos { get; set; }
    }
    [Table("Tipos_Ponto")]
    class Tipo_Ponto
    {   [Key]
        public int ID_Nome { get; set; }
    }
    [Table("ConfigVaz")]
    class ConfigVaz
    {
        [Key]
        public int ID_ConfigV { get; set; }
        public int UnidadeMedida { get; set; }
        [ForeignKey("Pontos")]
        public int Ponto_ID { get; set; }
        public Ponto Ponto { get; set; }
    }
    [Table("ConfigNv")]

    class ConfigNv
    {   [Key]
        public int ID { get; set; }
        public int LimSup { get; set; }
        public int LimInf { get; set; }
        [ForeignKey("Pontos")]
        public int Ponto_ID { get; set; }
        public Ponto Ponto { get; set; }
    }
    [Table("ConfigBomba")]

    class ConfigBomba
    {
        [Key]
        public int ID { get; set; }
        public bool Estado { get; set; }
        [ForeignKey("Pontos")]
        public int Ponto_ID { get; set; }
        public Ponto Ponto { get; set; }

    }
    [Table("Leituras")]

    class Leitura
    {

    }
}
