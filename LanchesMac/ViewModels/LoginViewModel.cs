using System.ComponentModel.DataAnnotations;

namespace LanchesMac.ViewModels
{
    public class LoginViewModel
    {
        //Nome do usuario
        [Required(ErrorMessage = "Informe seu nome")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        //Senha do usuario
        [Required(ErrorMessage = "Informe sua senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        //Retorno da URL que o usuario esta anteriormente
        public string ReturnUrl { get; set; }
    }
}
