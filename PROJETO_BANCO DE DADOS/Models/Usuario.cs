using System.ComponentModel.DataAnnotations;

namespace PROJETO_BANCO_DE_DADOS.Models
{
    public class Usuario
    {
       [Display(Name = "Codigo")]
       public int idUsu { get; set; }
        [Display(Name = "Nome completo")]
        [Required(ErrorMessage ="O campo nome é obrigatorio")]
        public string nomeUsu { get; set; }
        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "O campo Cargo é obrigatorio")]
        public string Cargo { get; set; }
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatorio")]
        public DateTime Datanasc { get; set; }
    }
}
