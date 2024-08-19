using System.ComponentModel.DataAnnotations;

namespace Bofa.App.Domain.Core
{
    public class User
    {
        [DeniedValues(0)]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        public required string Name { get; set; }

        [Range(16,120, ErrorMessage ="Data inválida.")]
        public int Age { get; set; }
    }
}
