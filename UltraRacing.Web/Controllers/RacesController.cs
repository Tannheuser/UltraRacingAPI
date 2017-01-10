using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UltraRacing.Core.Models;
using UltraRacing.Web.Models.DataServices.Abstract;

namespace UltraRacing.Web.Controllers
{
    public class RacesController : Controller
    {
        private readonly IRacesService _racesRepository;

        public RacesController(IRacesService racesRepository)
        {
            _racesRepository = racesRepository;
        }

        [Route("api/races")]
        public IEnumerable<Race> Get()
        {
            return _racesRepository.GetAll();
        }
    }
}