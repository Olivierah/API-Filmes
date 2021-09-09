using System;
using System.ComponentModel.DataAnnotations;


namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo título é obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Diretor é obrigatório!")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "O campo Genero é obrigatório!")]
        public string Genero { get; set; }

        [Range(1, 240, ErrorMessage = "A duração deve respeitar os limites entre 1 e 240 minutos!")]
        public int Duracao { get; set; }
    }
}
