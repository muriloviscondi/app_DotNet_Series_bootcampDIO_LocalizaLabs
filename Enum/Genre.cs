using System.ComponentModel.DataAnnotations;

namespace app_DotNet_Series_bootcampDIO_LocalizaLabs
{
  public enum Genre
  {
    [Display(Name = "Ação")]
    Action = 1,

    [Display(Name = "Aventura")]
    Adventure = 2,

    [Display(Name = "Comédia")]
    Comedy = 3,

    [Display(Name = "Documentário")]
    Documentary = 4,

    [Display(Name = "Drama")]
    Drama = 5,

    [Display(Name = "Espionagem")]
    Espionage = 6,

    [Display(Name = "Faroeste")]
    Western = 7,

    [Display(Name = "Fantasia")]
    Fantasy = 8,

    [Display(Name = "Ficção Científica")]
    Scifi = 9,

    [Display(Name = "Musical")]
    Musical = 10,

    [Display(Name = "Romance")]
    Romance = 11,

    [Display(Name = "Suspense")]
    Thriller = 12,

    [Display(Name = "Terror")]
    Horror = 13,
  }
}