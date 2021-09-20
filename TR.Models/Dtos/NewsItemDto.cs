using System;

namespace technicalRadiation.Models.Dtos
{
  public class NewsItemDto
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string ImgSource { get; set; }

    public string ShortDescription { get; set; }

  }
}