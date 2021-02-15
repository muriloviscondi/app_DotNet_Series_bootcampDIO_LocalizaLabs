using System.Collections.Generic;
using Interfaces;

namespace app_DotNet_Series_bootcampDIO_LocalizaLabs
{
  public class RepositorySerie : IRepository<Serie>
  {
    private List<Serie> serieList = new List<Serie>();

    public void Alter(int id, Serie entity)
    {
      serieList[id] = entity;
    }

    public void Create(Serie entity)
    {
      serieList.Add(entity);
    }

    public void Delete(int id)
    {
      serieList[id].Exclude();
    }

    public Serie IdResponse(int id)
    {
      return serieList[id];
    }

    public List<Serie> List()
    {
      return serieList;
    }

    public int nextId()
    {
      return serieList.Count;
    }
  }
}