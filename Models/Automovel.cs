using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTb01Lab1_LALC.Models
{
    public class Automovel
    {
        public int AutomovelId { get; set; }

        [Required(ErrorMessage ="Tipo é obrigatório")]
        [StringLength(300, ErrorMessage = "Máximo 300 caracteres")]
        public Tipo Tipo { get; set; }

        [Required(ErrorMessage = "Descrição é Obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage ="Marca é obrigatório")]
        [StringLength(100, ErrorMessage ="Máximo 100 caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Disponível é obrigatório")]
        public bool Disponivel { get; set; }

        [Required(ErrorMessage = "Data de cadastro é obrigatório")]
        public DateTime DataCadastro { get; set; }
    }
}
