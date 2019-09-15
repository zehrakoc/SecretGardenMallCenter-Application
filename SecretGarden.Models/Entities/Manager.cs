using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretGarden.Models.Entities
{
   public class Manager
    {
        [Key]
        public int Id { get; set; }

        public bool IsActive { get; set; }

        [MaxLength(50), Index(IsUnique = true)]
        public string UserName { get; set; }

        [MaxLength(20)]
        public string Password { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(20)]
        public string TcNo { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }
    }
}
