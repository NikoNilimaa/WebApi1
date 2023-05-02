using WebApi1.DTOs;
using WebApi1.Entities;

namespace WebApi1
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item) 
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate,
            };
        }
    }
}
