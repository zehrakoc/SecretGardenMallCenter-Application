using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecretGarden.Models.Entities
{
    public class CategoryStore
    {
        [Key, ForeignKey("Category"), Column(Order =10)]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Key, ForeignKey("Store"), Column(Order =20)]
        public int StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}
