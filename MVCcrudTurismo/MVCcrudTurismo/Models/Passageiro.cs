using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCcrudTurismo.Models
{
    public class Passageiro
    {
        [Key]
        public int PassageiroId { get; set; }

        [Column(TypeName = "varchar(200)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio")]
        [DisplayName("Nome")] 
        public string NomePassageiro { get; set; }


        [Column(TypeName="varchar(15)")]
        [DisplayName("CPF")]
        public string CpfPassageiro { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Pagamento")]
        public string Pagamento { get; set; }

        [Column(TypeName = "varchar(250)")]
        [DisplayName("Destino")]
        public string Destino { get; set; }

    }
}
