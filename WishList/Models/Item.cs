using System;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description
        { 
          get;
          set; 
        }

        internal void Add(object items)
        {
            throw new NotImplementedException();
        }
    }
}
