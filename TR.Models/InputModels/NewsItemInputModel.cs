using System.ComponentModel.DataAnnotations;

namespace technicalRadiation.Models.InputModels
{
    public class NewsItemInputModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string ImgSource { get; set; }
        [Required]
        [MaxLength(50)]
        public string ShortDescription { get; set; }
        [MinLength(50)]
        [MaxLength(255)]
        public string LongDescription { get; set; }
        [Required]
        public string PublishDate { get; set; }
    }
}