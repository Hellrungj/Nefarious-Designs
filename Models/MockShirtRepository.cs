using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NefariousDesigns.Models
{
    public class MockShirtRepository : IShirtRepository
    {
        private List<Shirt> _shirts;

        public MockShirtRepository()
        {
            if (_shirts == null)
            {
                InitializeShirts();
            }
        }

        private void InitializeShirts()
        {
            _shirts = new List<Shirt>
            {
                new Shirt { Id = 1, Name = "Red Shirt", Price = 12.99M, ShortDescription = "It's a me. Mario!", LongDescription = "Red T-Shirt for sale for 12.99", ImageUrl = "https://via.placeholder.com/1280x720.png/FF0000/000000", ImageThumbnailUrl = "https://via.placeholder.com/300x150.png/FF0000/000000"},
                new Shirt { Id = 2, Name = "Blue Shirt", Price = 12.99M, ShortDescription = "Sonic!", LongDescription = "Blue T-Shirt for sale for 12.99", ImageUrl = "https://via.placeholder.com/1280x720.png/0000FF/FFFFFF", ImageThumbnailUrl = "https://via.placeholder.com/300x150.png/0000FF/FFFFFF"},
                new Shirt { Id = 3, Name = "Yellow Shirt", Price = 12.99M, ShortDescription = "Big Bird", LongDescription = "White T-Shirt for sale for 12.99", ImageUrl = "https://via.placeholder.com/1280x720.png/FFFF00/000000", ImageThumbnailUrl = "https://via.placeholder.com/300x150.png/FFF00/000000"},
                new Shirt { Id = 4, Name = "White Shirt", Price = 12.99M, ShortDescription = "Darkness my old friend", LongDescription = "Black T-Shirt for sale for 12.99", ImageUrl = "https://via.placeholder.com/1280x720.png/FFFFFF/000000", ImageThumbnailUrl = "https://via.placeholder.com/300x150.png/FFFFFF/000000"},
                new Shirt { Id = 5, Name = "Black Shirt", Price = 12.99M, ShortDescription = "Don't follow the white light!", LongDescription = "White T-Shirt for sale for 12.99", ImageUrl = "https://via.placeholder.com/1280x720.png/000000/FFFFFF", ImageThumbnailUrl = "https://via.placeholder.com/300x150.png/000000/FFFFFF"}
            };
        }

        public IEnumerable<Shirt> GetAllShirts()
        {
            return _shirts;
        }

        public Shirt GetShirtById(int shirtId)
        {
            return _shirts.FirstOrDefault(p => p.Id == shirtId);
        }
    }
}
