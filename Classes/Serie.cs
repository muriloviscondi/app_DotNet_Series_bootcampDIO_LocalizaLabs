using System;

namespace app_DotNet_Series_bootcampDIO_LocalizaLabs
{
  public class Serie : BaseEntity
  {
    public Serie(int id, string title, string description, Genre genre, int year)
    {
      this.Id = id;
      this.Title = title;
      this.Description = description;
      this.Genre = genre;
      this.Year = year;
      this.Excluded = false;

    }
    private string Title { get; set; }

    private string Description { get; set; }

    private Genre Genre { get; set; }

    private int Year { get; set; }

    private bool Excluded { get; set; }

    public string titleResponse()
    {
      return this.Title;
    }

    public int idResponse()
    {
      return this.Id;
    }

    public void Exclude() {
      this.Excluded = true;
    }

    public override string ToString()
    {
      string newString = "";
      newString += $"Título: {this.Title} {Environment.NewLine}";
      newString += $"Descrição: {this.Description} {Environment.NewLine}";
      newString += $"Gênero: {this.Genre} {Environment.NewLine}";
      newString += $"Ano: {this.Year} {Environment.NewLine}";

      return newString;
    }
  }
}