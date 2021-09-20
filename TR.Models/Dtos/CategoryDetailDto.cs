using System;

namespace technicalRadiation.Models.Dtos
{

  public class CategoryDetailDto
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string slug { get; set; }

    public int NumberOfNewsItems { get; set; }
  }
}

