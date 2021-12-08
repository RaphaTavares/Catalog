using System;
using System.ComponentModel.DataAnnotations;

namespace catalog.Dtos
{
    //using record instead of classes for DTO's
    public record CreateItemDto
    {
        //using init instead of set because with that you can only set the value when initializing the object
        [Required]
        public String Name { get; init; }
        [Required]
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}
