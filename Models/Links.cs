using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkHubApp.Models
{
    public class Links
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", NullDisplayText = "")]
        public DateTime? Date { get; set; }

        [StringLength(500)] 
        public string LinkName { get; set; } = string.Empty;

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string LinkType { get; set; } = string.Empty;

        [DataType(DataType.Url)]
        [StringLength(200)]
        public string LinkUrl { get; set; } = string.Empty;

        [Required]
        public string LinkDescription { get; set; } = string.Empty;

    }
}
