using System.ComponentModel.DataAnnotations;

namespace SwaggerWebApi.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100,MinimumLength =  3, ErrorMessage = "O nome do Jogo deve conter entre 3 e 100 caracteres")]
        public string Nome {get; set;}

        [Required]
        [StringLength(100,MinimumLength =  1, ErrorMessage = "O nome da produtora deve conter entre 1 e 100 caracteres")]
        public string Produtora{get; set;}

        [Required]
        [Range(1,1000,ErrorMessage = "Preço deve estar entre 1 e 1000 Reais")]
        public double Preco{get; set;}
    }
}