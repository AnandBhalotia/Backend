using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.Entities
{
    public class Waste
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Waste_Id { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        [StringLength(100)]
        public string Primary_Substance { get; set; }

        [StringLength(100)]
        public string Quantity { get; set; }

        [StringLength(100)]
        public string From { get; set; }

        [StringLength(100)]
        public string To { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        [StringLength(100)]
        public string Energy { get; set; }
    }
}
