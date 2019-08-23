using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectAPI.Models
{
    [Table("parks")]
    public class Park
    {
        [Key]
        public int ParkId { get; set; }
        public string NationalPark { get; set; }
        public string Description { get; set; }

    }
}