using System.Collections.Generic;
using System.Linq;
using UltraRacing.Core.Models;
using UltraRacing.Web.Models.DataServices.Abstract;

namespace UltraRacing.Web.Models.DataServices
{
    public class RacesService : IRacesService
    {
        private readonly RacingContext _context;

        public RacesService(RacingContext context)
        {
            _context = context;
        }

        public IList<Race> GetAll()
        {
            return _context.Races.ToList();
        }
    }
}