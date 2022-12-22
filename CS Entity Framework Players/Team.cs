using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_Entity_Framework_Players
{
    [Table("team")]
    public class Team
    {

        [Key]
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; }
        public string City { get; set; }
        public string Coach { get; set; }
        public string Colors { get; set; }

        public List<Player> Players { get; set; }



    }
}
