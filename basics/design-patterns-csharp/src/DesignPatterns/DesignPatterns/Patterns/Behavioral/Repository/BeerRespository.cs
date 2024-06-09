using DesignPatterns.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Behavioral.Repository
{
    internal class BeerRespository : IBeerRepository
    {
        private DesignPatternsContext _context;

        public BeerRespository(DesignPatternsContext context)
        {
            _context = context;
        }

        public void Add(Beer beer) => _context.Beers.Add(beer);

        public void Delete(int id)
        {
            var beerToDelete = _context.Beers.Find(id);
            _context.Beers.Remove(beerToDelete);
        }

        public IEnumerable<Beer> Get() => _context.Beers.ToList();

        public Beer GetBeer(int id) => _context.Beers.Find(id);

        public void Update(Beer beer) => _context.Entry(beer).State = EntityState.Modified;
        
        public void Save() => _context.SaveChanges();
    }
}
