using System.ComponentModel.DataAnnotations;

namespace technicalRadiation.Models.InputModels
{
    public class AuthorInputModel
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
    }
}