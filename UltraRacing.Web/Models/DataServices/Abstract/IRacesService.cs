using System.Collections.Generic;
using UltraRacing.Core.Models;

namespace UltraRacing.Web.Models.DataServices.Abstract
{
    public interface IRacesService
    {
        IList<Race> GetAll();
    }
}