using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Behavioral.Repository
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> Get();
        Beer GetBeer(int id);
        void Add(Beer beer);
        void Delete(int id);
        void Update(Beer beer);

        void Save();
    }
}
