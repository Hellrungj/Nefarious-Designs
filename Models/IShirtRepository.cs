using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NefariousDesigns.Models
{
    public interface IShirtRepository
    {
        IEnumerable<Shirt> GetAllShirts();

        Shirt GetShirtById(int shirtId);
    }
}
