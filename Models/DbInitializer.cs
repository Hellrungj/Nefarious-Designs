using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NefariousDesigns.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Shirts.Any())
            {
                context.AddRange
                (
                    new Shirt { Name = "Red Shirt", Price = 12.99M, ShortDescription = "It's a me. Mario!", LongDescription = "Red T-Shirt for sale for 12.99", ImageUrl = "https://via.placeholder.com/1280x720.png/FF0000/000000", ImageThumbnailUrl = "https://via.placeholder.com/300x150.png/FF0000/000000", IsShirtOfTheWeek = true },
                    new Shirt { Name = "Blue Shirt", Price = 12.99M, ShortDescription = "Sonic!", LongDescription = "Blue T-Shirt for sale for 12.99", ImageUrl = "https://via.placeholder.com/1280x720.png/0000FF/FFFFFF", ImageThumbnailUrl = "https://via.placeholder.com/300x150.png/0000FF/FFFFFF", IsShirtOfTheWeek = true },
                    new Shirt { Name = "Yellow Shirt", Price = 12.99M, ShortDescription = "Big Bird", LongDescription = "White T-Shirt for sale for 12.99", ImageUrl = "https://via.placeholder.com/1280x720.png/FFFF00/000000", ImageThumbnailUrl = "https://via.placeholder.com/300x150.png/FFF00/000000", IsShirtOfTheWeek = true },
                    new Shirt { Name = "White Shirt", Price = 12.99M, ShortDescription = "Darkness my old friend", LongDescription = "Black T-Shirt for sale for 12.99", ImageUrl = "https://via.placeholder.com/1280x720.png/FFFFFF/000000", ImageThumbnailUrl = "https://via.placeholder.com/300x150.png/FFFFFF/000000", IsShirtOfTheWeek = true },
                    new Shirt { Name = "Black Shirt", Price = 12.99M, ShortDescription = "Don't follow the white light!", LongDescription = "White T-Shirt for sale for 12.99", ImageUrl = "https://via.placeholder.com/1280x720.png/000000/FFFFFF", ImageThumbnailUrl = "https://via.placeholder.com/300x150.png/000000/FFFFFF", IsShirtOfTheWeek = true },
                    new Shirt { Name = "Green Shirt", Price = 12.99M, ShortDescription = "Got green for days!", LongDescription = "Green T-Shirt for sale for 12.99", ImageUrl = "https://via.placeholder.com/1280x720.png/000000/FFFFFF", ImageThumbnailUrl = "https://via.placeholder.com/300x150.png/00ff00/000000", IsShirtOfTheWeek = true }
                );
                context.SaveChanges();
            }
        }
    }
}
