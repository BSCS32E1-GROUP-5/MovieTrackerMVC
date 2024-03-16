using MovieTrackerMVC.Models.Domain;
using MovieTrackerMVC.Models.DTO;

namespace MovieTrackerMVC.Repositories.Abstract
{
    public interface IGenreService
    {
       bool Add(Genre model);
       bool Update(Genre model);
       Genre GetById(int id);
       bool Delete(int id);
       IQueryable<Genre> List();

    }
}
