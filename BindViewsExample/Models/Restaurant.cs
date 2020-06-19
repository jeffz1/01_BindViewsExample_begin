using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindViewsExample.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Open { get; set; }
        public string Speciality { get; set; }
        [Display(Name = "Score (0-4)")]
        public int Review { get; set; }
    }
}
