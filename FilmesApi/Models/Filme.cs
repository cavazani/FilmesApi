using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models {
    public class Filme 
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo titulo é obrigatorio")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatorio")]
        public string? Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero não pode passar de 30 caracteres")]
        public string? Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter no minimo 1 e bi naxuni 600 minutos")]
        public int Duracao { get; set; }

    }
}
