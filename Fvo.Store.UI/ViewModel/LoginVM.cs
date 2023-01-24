using System.ComponentModel.DataAnnotations;

namespace Fvo.Store.UI.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage =" O {0} é obrigatório"), StringLength(80, ErrorMessage ="O Limite do {0} é de {1}")]
        [RegularExpression(@"([\w\.\-]+)@([\w\.\-]+)((\.(\w){2,3})+)", ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = " O {0} é obrigatório"), StringLength(40, ErrorMessage = "O Limite do {0} é de {1}")]
        public string Senha { get; set; }

        public bool PermanecerLogado { get; set; }

        public string ReturnURL { get; set; }
    }
}