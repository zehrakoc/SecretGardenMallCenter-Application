using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SecretGarden.Models.Entities
{

    public class Store
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int Location { get; set; }

        [Required, MaxLength(255)]
        public string LocationDetail { get; set; }
        public bool IsItHired { get; set; }
        public decimal? HirePrice { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<CategoryStore> CategoryStores { get; set; }

        public override string ToString()
        {
            return $"({Name}) {Location} {LocationDetail}";
        }
    }
}
