using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NefariousDesigns.Models
{
    public class ShirtRepository: IShirtRepository
    {
        private readonly AddDbContext _appDbContext;

        public ShirtRepository(AddDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Shirt> GetAllShirts()
        {
            return _appDbContext.Shirts;
        }

        public Shirt GetShirtById(int shirtId)
        {
            return _appDbContext.Shirts.FirstOrDefault(p => p.Id == shirtId);
        }
    }
}
