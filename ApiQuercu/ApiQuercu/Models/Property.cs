using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiQuercu.Models
{
    public class Property
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PropertyType")]
        public int PropertyTypeId { get; set; }

        [ForeignKey("Owner")]
        public int OwnerId { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Number { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Address { get; set; }

        public Decimal Area { get; set; }

        public Decimal ConstructionArea { get; set; }

        public PropertyType PropertyType { get; set; }
        public Owner Owner { get; set; }
    }
}
